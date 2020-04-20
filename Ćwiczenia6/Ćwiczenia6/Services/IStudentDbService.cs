using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ćwiczenia6.DTOs.Request;

namespace Ćwiczenia6.Services
{
    /// <summary>
    /// Interfejs zawierający metody do modyfikowania bazy danych
    /// </summary>
    public interface IStudentDbService
    {
        /// <summary>
        /// Metoda do dodawania nowego studenta
        /// </summary>
        /// <param name="request">Parametr z danymi nowego studenta</param>
        void EnrollStudent(EnrollStudentRequest request);

        /// <summary>
        /// Metoda do promowania studenta na nowy semestr
        /// </summary>
        /// <param name="semester">Nowy semestr</param>
        /// <param name="studies">Wydział</param>
        void PromoteStudent(int semester, string studies);
    }
}
