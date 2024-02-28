﻿using System.ComponentModel.DataAnnotations;

namespace BlogTrackerWebapp.Models
{
    public class EmpLogin
    {
        [Required]
        [EmailAddress]
        public string? EmailId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public int PassCode { get; set; }
    }
}
