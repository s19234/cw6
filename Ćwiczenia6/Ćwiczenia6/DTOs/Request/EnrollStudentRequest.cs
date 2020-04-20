using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ćwiczenia6.DTOs.Request
{
    /// <summary>
    /// Klasa przechowująca potrzebne dane do dodawania studenta
    /// </summary>
    public class EnrollStudentRequest
    {
        /// <summary>
        /// Indeks studenta
        /// </summary>
        public string IndexNumber { get; set; }

        /// <summary>
        /// Email studenta
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Imię studenta - nie puste, nie dłuższe niż 10 znaków
        /// </summary>
        [Required(ErrorMessage = "Musisz podać imię")]
        [MaxLength(10)]
        public string FirstName { get; set; }
        
        /// <summary>
        /// Nazwisko studenta - nie puste, nie dłuższe niż 255 znaków
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }

        /// <summary>
        /// Data urodzenia studenta
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Wydział studiów
        /// </summary>
        [Required]
        public string Studies { get; set; }
    }
}
