using System;
using System.Collections.Generic;
using System.Text;
using Stanislava_Georgieva_36_501219056_ex_3;

namespace WpfApplication
{
    class StudentValidation
    {
        private Student GetStudentDataById(User user)
        {
            user = new User();
            Student student = new Student();
                if(student.fNumber != null || student.fNumber!="501219056" || user.fNumber != null || user.fNumber != "501219056")
            {
                Console.WriteLine("Edit student faculty number");
            }
            return student;
        }
    }
}
