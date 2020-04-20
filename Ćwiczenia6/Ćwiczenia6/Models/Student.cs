using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ćwiczenia6.Models
{
    /// <summary>
    /// Klasa przechowująca dane o studencie
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Indeks studenta
        /// </summary>
        public string IndexNumber { get; set; }

        /// <summary>
        /// Imię studenta
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Nazwisko studenta
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Data urodzin studenta
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Wydział
        /// </summary>
        public string Studies { get; set; }

        /// <summary>
        /// Aktualny semestr studenta
        /// </summary>
        public int Semester { get; set; }
    }
}
