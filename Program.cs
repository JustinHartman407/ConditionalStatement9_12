using System;
/* User: Justin Hartman
 * Date: 9/12/2019
 * Assignment: Conditional Statement
 */
namespace ConditionalStatementDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is the grade that your expect to get in this course?");

            try
            {
                string input = Console.ReadLine();
                int grade = int.Parse(input);

                if ((grade >= 90) && (grade <= 100))
                {
                    Console.WriteLine("Your Grade is an A");
                    Console.WriteLine("Press any key to leave ");
                    Console.ReadKey(true);
                }
                else if ((grade >= 80) && (grade <= 89))
                {
                    Console.WriteLine("Your Grade is an B");
                    Console.WriteLine("Press any key to leave ");
                    Console.ReadKey(true);
                }
                else if ((grade >= 70 && (grade <= 79)))
                {
                    Console.WriteLine("Your Grade is an C");
                    Console.WriteLine("Press any key to leave ");
                    Console.ReadKey(true);
                }
                else if ((grade >= 60 && (grade <= 69)))
                {
                    Console.WriteLine("Your Grade is an D");
                    Console.WriteLine("Press any key to leave ");
                    Console.ReadKey(true);
                }
                else if ((grade >= 0 && (grade <= 59)))
                {
                    Console.WriteLine("Your Grade is an F");
                    Console.WriteLine("Press any key to leave ");
                    Console.ReadKey(true);
                }

            }
            catch
            {
                Console.WriteLine("What you have entered is producing an error");
            }
        }
    }
}
