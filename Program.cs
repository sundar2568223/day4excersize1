using System;
namespace excersize1
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter marks in Pre: ");
            int preMarks = Convert.ToInt32(Console.ReadLine());

            if (preMarks > 60)
            {
                Console.Write("Enter marks in Final: ");
                int finalMarks = Convert.ToInt32(Console.ReadLine());

                if (finalMarks > 55)
                {
                    Console.WriteLine("Selected");
                }
                else
                {
                    Console.WriteLine("Fail in Final");
                }
            }
            else
            {
                Console.WriteLine("Fail in Pre");
            }

            Console.ReadLine();
        }
    }
}