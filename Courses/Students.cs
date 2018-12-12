using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    public static class students
    {
        private static string FirstName;
        private static string SecondName;
        private static int NumberOfCourses;
        private static string CourseNumber;
        private static string CourseType;
        private static string StartDate;


        public static string getStudentsFirstName()
        {
            return FirstName;

        }

        public static string getStudentsSecondName()

        {

            return SecondName;

        }

        public static int  getStudentsNumberOfcourses()

        {

            return NumberOfCourses;

        }
        public static string getStudentsCourseNumber()

        {

            return CourseNumber;

        }
        public static string getStudentsCourseType()

        {

            return CourseType;

        }

        public static string getStartDate()

        {

            return StartDate;

        }


        public static void setFirstName(string studentFirstName)
        {
            FirstName = studentFirstName;
            
        }

        public static void setLastName( string studentSecondName)
           
        {
            
            SecondName = studentSecondName;
           
        }
      
        public static void setStudentsNumberOfCourses(int studentNumberOfCourses)
           
        {
         
            NumberOfCourses = studentNumberOfCourses;
            
        }
        public static void setStudentsCourseNumber(string studentCourseNumber)
        {
            
            CourseNumber = studentCourseNumber;
           
        }
        public static void setStudentCourseType( string studentCourseType)
           
        {
            
            CourseType = studentCourseType;
            
        }
        public static void SetStudentDate( string studentStartDate)
        {
           
            StartDate = studentStartDate;
        }
    }
}


    

