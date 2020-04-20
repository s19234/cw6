using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Ćwiczenia6.DTOs.Request;
using Ćwiczenia6.Models;

namespace Ćwiczenia6.Services
{
    /// <summary>
    /// Klasa do manipulacji bazą danych w Management Studio
    /// </summary>
    public class SqlServerStudentDbService : IStudentDbService
    {
        public SqlServerStudentDbService() { }

        public void EnrollStudent(EnrollStudentRequest request)
        {
            var st = new Student();
            st.FirstName = request.FirstName;
           
            using (var con = new SqlConnection(""))
            using (var com = new SqlCommand())
            {
                com.Connection = con;
                con.Open();

                var tran = con.BeginTransaction();

                try
                {
                    com.CommandText = "Select IdStudies FROM Studies WHERE name=@name";
                    com.Parameters.AddWithValue("name", request.FirstName);

                    var dr = com.ExecuteReader();
                    if (!dr.Read())
                        tran.Rollback();

                    int idstudies = (int)dr["studies"];

                    com.CommandText = "INSERT INTO Student(IndexNumber, FirstName) VALUES(@Index, @Fname)";
                    com.Parameters.AddWithValue("Index", request.IndexNumber);
                    com.Parameters.AddWithValue("Fname", request.FirstName);

                    com.ExecuteNonQuery();
                    tran.Commit();
                }
                catch(SqlException)
                {
                    tran.Rollback();
                }
            }
        }

        public void PromoteStudent(int semester, string studies)
        {
            throw new NotImplementedException();
        }
    }
}
