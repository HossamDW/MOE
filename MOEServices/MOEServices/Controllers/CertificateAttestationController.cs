using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MOEServices.Core.Entities;
using MOEServices.Core.Interfaces.Services;

namespace MOEServices.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CertificateAttestationController : ControllerBase
	{
		private readonly ICertificateAttestationService _attestationService;

		public CertificateAttestationController(ICertificateAttestationService service)
		{
			_attestationService = service;
		}

		// GET: api/City
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var result = _attestationService.GetAll();

			return Ok(new { Success = true, Data = result });
		}

		// POST: api/CertificateAttestation
		[HttpPost]
		public async Task<IActionResult> Post(CertificateAttestation value)
		{
			if (ModelState.IsValid)
			{
				var result = await _attestationService.CreateAsync(value);
				return Ok(result);
			}
			return Ok(new { Success = false, Message = getErrorMessages() });
		}

		private string getErrorMessages()
		{
			var msg = string.Join(',', ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage)));
			return msg;
		}
	}
}
