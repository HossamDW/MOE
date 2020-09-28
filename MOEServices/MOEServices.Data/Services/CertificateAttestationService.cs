using Microsoft.EntityFrameworkCore;
using MOEServices.Core.Entities;
using MOEServices.Core.Interfaces.Services;
using MOEServices.Core.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Infrastructure.Data;
using Entities = MOEServices.Core.Entities;

namespace Task.Services.Data
{
    public class CertificateAttestationService : ICertificateAttestationService
    {
        private readonly MoeDBContext _context;

        public CertificateAttestationService(MoeDBContext context)
        {
            _context = context;
        }

		public async Task<OperationResult> CreateAsync(CertificateAttestation entityToCreate)
		{
			entityToCreate.CreatedAt = DateTime.Now;
			entityToCreate.ModifiedAt = DateTime.Now;

			await _context.CertificateAttestations.AddAsync(entityToCreate);
			await _context.SaveChangesAsync();
			return OperationResult.Succeeded();
		}
    }
}
