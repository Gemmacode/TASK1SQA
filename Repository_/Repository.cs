using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1SQA.Repository_
{
    internal class  Repository 
    {


        public string GetCourseCode()
        {
            string course;
            do   
            {
                Console.Clear();
                Console.Write($"Enter course Code:  ");
                course = Console.ReadLine();
            } while (course == "");

            return course;
        }






        public int GetCourseUnit() 
        {
            string courseunit; 
            do
            {
                Console.Clear();
                Console.Write($"Enter course Unit:  ");
                courseunit = Console.ReadLine();
            } while (!int.TryParse(courseunit, out _) || courseunit == "");

            return int.Parse(courseunit);
        }






        public double GetCourseScore()
        {
            string rawscore;
            do   //  do-while loop for course score
            {
                Console.Clear();
                Console.Write($"Enter your course score\nEnsure the score is within range 0 - 100:  ");
                rawscore = Console.ReadLine();
            } while (!Double.TryParse(rawscore, out _) || double.Parse(rawscore) < 0 || double.Parse(rawscore) > 100);
            return Convert.ToDouble(rawscore);
        }







        public void WelcomeMessage() 
        {
                      
            Console.WriteLine("Hello and welcome to your favourite GPA CALCULATOR"); 
            
        }






        public int NumberOfCoursesYouWantToCheck()
        {
            string n;
            do
            {             
                Console.Write("Please Input the number of courses you would like to check:NOTE!.\n You would only proceed if your input is a number.Thank you !\n Input it Here:");
                n = Console.ReadLine();
            }
            while (!int.TryParse(n, out _));
            return int.Parse(n);
        }





    }
}
