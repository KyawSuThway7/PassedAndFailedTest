using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch20Algorithm
{
    class PassedAndFailed
    {
        static void Main(string[] args)
        {
            Console.Write("Student's Grade : ");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input>=60)
            {
                Console.WriteLine("Result : Passed");
                if(input>=60&&input<=70)
                {
                    Console.WriteLine("Your Great is C");
                }
                else if (input>70&&input<=80)
                {
                    Console.WriteLine("Your Grate is B");
                }
                else if (input > 80 && input <= 90)
                {
                    Console.WriteLine("Your Grate is A");
                }
                else if (input > 90 && input <= 100)
                {
                    Console.WriteLine("Your Grate is A+");
                }
            }
            else
            {
                Console.WriteLine("Result : Failed");
                int result = 60 - input;
                Console.WriteLine($"Your great need {result} marks to pass this Exam ");
            }
            Console.WriteLine("Press any key to close the window");
            Console.ReadKey();
        }
    }
}
