

using TASK1SQA.Controller;
using TASK1SQA.Repository_;
using TASK1SQA.PrintTable_;

namespace TASK1SQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repo = new Repository();


            repo.WelcomeMessage();
            var noOfCourseToCheck = repo.NumberOfCoursesYouWantToCheck();
  

            GpaController.GpaChecker(noOfCourseToCheck);
            PrintTable.PrintMyTable();
        }
    }
}