using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApplication
{
    public class StudentData
    {
        protected  List<Student> TestStudents { get; set; }
        public StudentData() { }
         public Student SetDataToStudent()
        {

            if (TestStudents == null)
            {

                TestStudents = new List<Student>();
                TestStudents.Add(new Student());
                TestStudents[0].firstName = "Steliyan";
                TestStudents[0].lastName = "Todorov";
                TestStudents[0].lastName = "Iliev";
                TestStudents[0].fNumber = "501219031";
                TestStudents[0].faculty = "fkst";
                TestStudents[0].specialty = "ITI";
                TestStudents[0].qualification = "Programmer";
                TestStudents[0].status = "zaveril";
                TestStudents[0].course = "3";
                TestStudents[0].flow = "1";
                TestStudents[0].group = "36";
                TestStudents[0].OKS = "OKS";


            TestStudents.Add(new Student());
                TestStudents[1].firstName = "Ivelin";
                TestStudents[1].sirName = "Ivov";
                TestStudents[1].lastName = "Iliev";
                TestStudents[1].fNumber = "501219032";
                TestStudents[1].faculty = "fkst";
                TestStudents[1].specialty = "KSI";
                TestStudents[1].qualification = "Programmer";
                TestStudents[1].status = "zaveril";
                TestStudents[1].course = "3";
                TestStudents[1].flow = "2";
                TestStudents[1].group = "32";
                TestStudents[1].OKS = "OKS";

             }
            return TestStudents[1];
        }
        public string getFirstName()
        {
           
            return TestStudents[1].firstName;
        }
        public string getSirName()
        {

            return TestStudents[1].sirName;
        }
        public string getLastName()
        {

            return TestStudents[1].lastName;
        }
        public string getCourse()
        {

            return TestStudents[1].course;
        }
        public string getFNumber()
        {

            return TestStudents[1].fNumber;
        }
        public string getFlow()
        {

            return TestStudents[1].flow;
        }
        public string getStatus()
        {

            return TestStudents[1].status;
        }
        public string getGroup()
        {

            return TestStudents[1].group;
        }
        public string getQualification()
        {

            return TestStudents[1].qualification;
        }
        public string getSpecialty()
        {

            return TestStudents[1].specialty;
        }
        public string getFaculty()
        {

            return TestStudents[1].faculty;
        }
        public string getOKS()
        {

            return TestStudents[1].OKS;
        }
    }
}
