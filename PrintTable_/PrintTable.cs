using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK1SQA.Controller;

namespace TASK1SQA.PrintTable_
{
    internal class PrintTable
    {


        public static void PrintMyTable()
        {
            Console.Clear();
            Console.WriteLine(" |------------------|-----------------|-----------|---------------|---------------|--------------|");
            Console.WriteLine(" | COURSE & CODE    | COURSE UNIT     | GRADE     | GRADE-UNIT    | WEIGHT Pt     | REMARK       |");
            Console.WriteLine(" |------------------|-----------------|-----------|---------------|---------------|--------------|");
            Console.WriteLine($"{GpaController.print_all}\n\n");
            Console.WriteLine($"Total course Unit registered is {GpaController.totalCourseUnitRegistered}");
            Console.WriteLine($"Total course Unit passed is {GpaController.totalCourseUnitPassed}");
            Console.WriteLine($"Total Weight point is {GpaController.totalWeightPoint}");
            Console.WriteLine($"GPA is {GpaController.gpa:F2}");

        }


    }
}
