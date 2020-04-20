using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Ćwiczenia6.DTOs.Responses
{
    /// <summary>
    /// Odpowiedź z bazy danych
    /// </summary>
    public class EnrollStudentResponse
    {
        /// <summary>
        /// Nazwisko studenta
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Aktualny semestr studenta
        /// </summary>
        public int Semester { get; set; }

        /// <summary>
        /// Data rozpoczęcia studiów
        /// </summary>
        public DateTime StartDate { get; set; }
    }
}
