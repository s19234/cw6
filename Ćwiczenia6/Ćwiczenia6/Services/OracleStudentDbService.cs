using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ćwiczenia6.DTOs.Request;

namespace Ćwiczenia6.Services
{
    /// <summary>
    /// Klasa do manipulacji bazą danych stworzoną w Oracle
    /// </summary>
    public class OracleStudentDbService : IStudentDbService
    {
        public void EnrollStudent(EnrollStudentRequest request)
        {
            throw new NotImplementedException();
        }

        public void PromoteStudent(int semester, string studies)
        {
            throw new NotImplementedException();
        }
    }
}
