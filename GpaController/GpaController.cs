using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using TASK1SQA.Repository_;

namespace TASK1SQA.Controller
{
    internal class GpaController
    {


        public static string print_all = "";
        public static char grade = ' ';
        public static int gradeUnit = 0;
        public static string remark = "";
        public static int weightPoint = 0;
        public static int totalCourseUnitRegistered = 0;
        public static int totalCourseUnitPassed = 0;
        public static int totalWeightPoint = 0;
        public static double gpa; 
       



        public static void GpaChecker( int numOfCoursesYouWantToCheck) 
        {

            for (int i = 0; i < numOfCoursesYouWantToCheck; i++)
            {
                var repo = new Repository();           
                string courseCode = repo.GetCourseCode();
                int courseUnit = repo.GetCourseUnit();
                double Score = repo.GetCourseScore();

                // if-statement to grade scores
                if (Score >= 70 && Score <= 100)
                {
                    grade = 'A';
                    gradeUnit = 5;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Excellent";                                     
                }
                else if (Score >= 60 && Score < 70)
                {
                    grade = 'B';
                    gradeUnit = 4;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Very Good";
                }
                else if (Score >= 50 && Score < 60)
                {
                    grade = 'C';
                    gradeUnit = 3;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Good";
                }
                else if (Score >= 45 && Score < 50)
                {
                    grade = 'D';
                    gradeUnit = 2;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Fair";
                }
                else if (Score >= 40 && Score < 45)
                {
                    grade = 'E';
                    gradeUnit = 1;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Pass";
                }
                else if (Score >= 0 && Score < 39)
                {
                    grade = 'F';
                    gradeUnit = 0;
                    weightPoint = courseUnit * gradeUnit;
                    remark = "Fail";
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("The inputed Number is out of range");
                    break;
                }


                // Collecting all print statements into variable "print_all". Each print statement is being appended to the previous print statement until iteration is concluded
                print_all = print_all + $" |    {courseCode,-14}|     {courseUnit,-12}|     {grade,-6}|    {gradeUnit,-11}|    {weightPoint,-11}|    {remark,-10}|\n";
                 

                //Calculating the total course units registered
                totalCourseUnitRegistered = totalCourseUnitRegistered + courseUnit;


                // Calculating the total course unit passed
                if (grade != 'F')
                {
                    totalCourseUnitPassed = totalCourseUnitPassed + courseUnit;
                }

                //Calculating the total weight point
                totalWeightPoint = totalWeightPoint + weightPoint;
            }

            //gpa formula
            gpa = totalWeightPoint / totalCourseUnitRegistered;



        }

    }
}
