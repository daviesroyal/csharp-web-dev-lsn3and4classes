using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        private List<Student> StudentRoster { get; set; }
        private int ClassPeriod { get; set; }
        private string CourseSubject { get; set; }
        private string TeacherName { get; set; }

        public Course(List<Student> studentRoster, int classPeriod, string courseSubject, string teacherName)
        {
            StudentRoster = studentRoster;
            ClassPeriod = classPeriod;
            CourseSubject = courseSubject;
            TeacherName = teacherName;
        }
    }
}
