﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Beginning_CSharp
{
    struct WebService
    {
        public (Student student, int[] grades) GetStudentProfile(int id)
        {
            var student = new Student();
            student.FirstName = "Joe";
            student.LastName = "Average";
            var grades = new int[] { 40, 70, 40 };
            
            return (student, grades);
        }
    }
}
