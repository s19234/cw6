﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ćwiczenia6.DTOs.Request
{
    public class EnrollStudentRequest
    {
        public string IndexNumber { get; set; }
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Musisz podać imię")]
        [MaxLength(10)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        public string Students { get; set; }
    }
}
