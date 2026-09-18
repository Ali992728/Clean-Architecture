using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyAPI.Core.DTO
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(100)]
        public string? Position { get; set; }

        [MaxLength(100)]
        [EmailAddress]
        public string? Email { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [MaxLength(15)]
        public string? PhoneNumber { get; set; }

        public DateTime? CreatedAtDate { get; set; }
        public DateTime? UpdatedAtDate { get; set; }

        [MaxLength(50)]
        public string? City { get; set; }
    }
}
