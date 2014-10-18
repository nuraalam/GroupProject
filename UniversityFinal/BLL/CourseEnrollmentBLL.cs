using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityFinal.DLL.GETWAY;

namespace UniversityFinal.BLL
{
    class CourseEnrollmentBLL
    {
        CourseEnrollmentGateway aCourseEnrollmentGateway=new CourseEnrollmentGateway();
        public string GetCourseName(string regNo)
        {
            string name = aCourseEnrollmentGateway.GetCourseName(regNo);
            return name;
        }

        public string GetCourseEmail(string regNo)
        {
            string email = aCourseEnrollmentGateway.GetEmailAddress(regNo);
            return email;
        }

        public List<string> GetCourseNameList()
        {
            List<string> aCourseNameList = aCourseEnrollmentGateway.GetCourseNameList();
            return aCourseNameList;
        }
    }
}
