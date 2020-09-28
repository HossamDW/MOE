using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using MOEServices.Core.Entities.Base;

namespace MOEServices.Core.Entities
{
    [Table("CertificateAttestation")]
    public class CertificateAttestation : BaseEntity 
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

		[Required]
		[MaxLength(100)]
		public string MiddleName { get; set; }

		[Required]
		[MaxLength(100)]
		public string LastName { get; set; }

		[Required]
		[MaxLength(100)]
		public string Phone { get; set; }

		[Required]
		[MaxLength(100)]
		public string Email { get; set; }

		[Required]
		public bool Gender { get; set; }

		[Required]
		[MaxLength(100)]
		public string NationalId { get; set; }

		[Required]
		public int RequestId { get; set; }

		[Required]
		public int EducationZoneId { get; set; }

		[Required]
		[MaxLength(100)]
		public string SchoolName { get; set; }

		[Required]
		[MaxLength(4)]
		public string AcademicYear { get; set; }

		[Required]
		public int GradeId { get; set; }

		[Required]
		public int StudyPeriodId { get; set; }

		[Required]
		public int EducationTypeId { get; set; }

		[Required]
		public int Status { get; set; }

		[Required]
		[MaxLength(1000)]
		public string IdCardPath { get; set; }

		[Required]
		[MaxLength(1000)]
		public string StudyCertificatePath { get; set; }

	}
}
