using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityFinal.BLL;
using UniversityFinal.DLL.DAO;

namespace UniversityApp
{
    public partial class CourseEnrollmentUI : Form
    {
        private CourseEnrollmentBLL aCourseEnrollmentBll;

        public CourseEnrollmentUI()
        {
            InitializeComponent();
            ShowCourseNameComboBox();
        }

        private void ShowCourseNameComboBox()
        {
            aCourseEnrollmentBll=new CourseEnrollmentBLL();
            List<string> courseNameList=aCourseEnrollmentBll.GetCourseNameList();
            foreach (string courseName in courseNameList)
            {
                courseCourseComboBox.Items.Add(courseName);
            }
            
          
        }

        private void findCourseButton_Click(object sender, System.EventArgs e)
        {
            aCourseEnrollmentBll = new CourseEnrollmentBLL();
            Student aStudent=new Student();
            aStudent.RegNo = regNoCourseTextBox.Text;
            nameCourseTextBox.Text = aCourseEnrollmentBll.GetCourseName(aStudent.RegNo);
            emailCourseTextBox.Text = aCourseEnrollmentBll.GetCourseEmail(aStudent.RegNo);
        }

        private void enrollButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
