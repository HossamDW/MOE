using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BOEServices.Web.Models;
using System.IO;
using MOEServices.Core.Entities;
using Microsoft.Extensions.Hosting;
using MOEServices.Core.Interfaces.Services;

namespace BOEServices.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly IHostEnvironment hostingEnvironment;
		private readonly ICertificateAttestationService _attestationService;

		public HomeController(IHostEnvironment environment, ICertificateAttestationService service)
		{
			hostingEnvironment = environment;
			_attestationService = service;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(CertificateAttestation model)
		{
			if (ModelState.IsValid)
			{
				var cardFileName = GetUniqueFileName(model.IdCardFile.FileName);
				var uploads = Path.Combine(hostingEnvironment.ContentRootPath, "uploads");
				var filePath = Path.Combine(uploads, cardFileName);
				model.IdCardFile.CopyTo(new FileStream(filePath, FileMode.Create));

				var certFileName = GetUniqueFileName(model.IdCardFile.FileName);
				filePath = Path.Combine(uploads, certFileName);
				model.StudyCertificateFile.CopyTo(new FileStream(filePath, FileMode.Create));

				await _attestationService.CreateAsync(model);

				return RedirectToAction("Done", "Home");
			}

			return RedirectToAction("Index", "Home");
		}

		private string GetUniqueFileName(string fileName)
		{
			fileName = Path.GetFileName(fileName);
			return Path.GetFileNameWithoutExtension(fileName)
					  + "_"
					  + Guid.NewGuid().ToString().Substring(0, 4)
					  + Path.GetExtension(fileName);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
