using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int failNum = int.Parse(Console.ReadLine());
            string taskName = Console.ReadLine();
            int taskGrade = int.Parse(Console.ReadLine());

            string lastTask= "";
            int taskcounter = 0;
            int failcounter = 0;
            double average = 0;
            bool isFlailed = true;

            if (taskGrade <= 4)
            {
                failcounter++;
            }

            while (failcounter < failNum)
            {
                average += taskGrade;
                taskcounter++;
                taskName = Console.ReadLine();
                if (taskName == "Enough")
                {
                    isFlailed = false;
                    break;
                }
                taskGrade = int.Parse(Console.ReadLine());
                if (taskGrade <= 4)
                {
                    failcounter++;
                }
               
                lastTask = taskName;
            }
            if (isFlailed)
            {
                Console.WriteLine($"You need a break, {failcounter} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {average / (taskcounter):f2}");
                Console.WriteLine($"Number of problems: {taskcounter }");
                Console.WriteLine($"Last problem: {lastTask}");
            }

           
            
           
        }
    }
}
