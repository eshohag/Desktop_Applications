using System;
using System.Data.SqlClient;
using Taslim.DAL.Model;

namespace Taslim.DAL.Gateway
{
    class StudentPerformanceGateway : CommonGateway
    {
        public int Add(StudentPerformance student)
        {
            Query = "INSERT INTO StudentsPerformance VALUES('" + student.Department + "','" + student.Semester + "','" + student.Batch + "','" + student.StudentId + "','" + student.Exam + "','" + student.ExtraCurriculum + "','" + student.TotalPerformanceValue + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public DepartmentMaxPer FindMaxPerformanceCSE()
        {
            Query = "Select * from CSE";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            DepartmentMaxPer aStudent = null;
            while (Reader.Read())
            {
                aStudent = new DepartmentMaxPer();
                aStudent.StudentID = Convert.ToInt32(Reader["StudentId"]);
                aStudent.Department = Reader["Department"].ToString();
                aStudent.MaxPerformanceValue = Convert.ToDecimal(Reader["TotalPerformanceValue"]);

            }
            Reader.Close();
            Connection.Close();
            return aStudent;

        }

        public DepartmentMaxPer FindMaxPerformanceEEE()
        {
            Query = "Select * from EEE";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            DepartmentMaxPer aStudent = null;
            while (Reader.Read())
            {
                aStudent = new DepartmentMaxPer();
                aStudent.StudentID = Convert.ToInt32(Reader["StudentId"]);
                aStudent.Department = Reader["Department"].ToString();
                aStudent.MaxPerformanceValue = Convert.ToDecimal(Reader["TotalPerformanceValue"]);

            }
            Reader.Close();
            Connection.Close();
            return aStudent;
        }
    }
}
