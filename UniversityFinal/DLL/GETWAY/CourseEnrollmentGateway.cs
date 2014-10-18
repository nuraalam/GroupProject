using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityFinal.DLL.GETWAY
{
    class CourseEnrollmentGateway
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string query;

        private static void CallForConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["University"].ConnectionString;
            connection = new SqlConnection(conn);
            connection.ConnectionString = conn;

        }

        public string GetCourseName(string regNo)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM StudentInfo");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            string name="";
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    if (regNo == aReader[1].ToString())
                        name = aReader[2].ToString();
                }
            }
            connection.Close();
            return name;
        }

        public string GetEmailAddress(string regNo)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM StudentInfo");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            string email = "";
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    if (regNo == aReader[1].ToString())
                        email = aReader[3].ToString();
                }
            }
            connection.Close();
            return email;
        }

        public List<string> GetCourseNameList()
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM CoursesInfo");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            List<string> courseNameList=new List<string>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    courseNameList.Add(aReader[2].ToString());
                }
            }
            connection.Close();
            return courseNameList;
        }
    }
}
