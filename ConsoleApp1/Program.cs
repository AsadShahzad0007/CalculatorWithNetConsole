using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main()
        {
            Calculation cal = new Calculation();

        first_num:
            try
            {
                Console.Write("Enter First Number: ");
                cal.num1 = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto first_num;
            }
        second_num:
            try
            {
                Console.Write("Enter Second Number: ");
                cal.num2 = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto second_num;
            }

            Console.WriteLine("\n \n !----   Calculation Menu   ----! \n\n 1- Addition \n 2-Subtraction \n 3-Multiplication \n 4- Division \n\n Enter Your Choice...! ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Sum of Input numbers = " + cal.sum());
                Console.WriteLine(" \n Enter 1 for again Calculation or press any key to exit.");
                string choice_second = Console.ReadLine();
                if (choice_second == "1")
                {
                    goto first_num;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("Subtraction of Input numbers = " + cal.subtract());
                Console.WriteLine(" \n Enter 1 for again Calculation or press any key to exit.");
                string choice_second = Console.ReadLine();
                if (choice_second == "1")
                {
                    goto first_num;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else if (choice == "3")
            {
                Console.WriteLine("Multiplication of Input numbers = " + cal.product());
                Console.WriteLine(" \n Enter 1 for again Calculation or press any key to exit.");
                string choice_second = Console.ReadLine();
                if (choice_second == "1")
                {
                    goto first_num;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("Division of Input numbers = " + cal.divide());
                Console.WriteLine(" \n Enter 1 for again Calculation or press any key to exit.");
                string choice_second = Console.ReadLine();
                if (choice_second == "1")
                {
                    goto first_num;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("You have enter the Invalid Choice...! \n Enter 1 for again Calculation or press any key to exit.");
                string choice_second = Console.ReadLine();
                if (choice_second == "1")
                {
                    goto first_num;
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            Console.ReadLine();
        }
    }

    public class Calculation
    {
        public double num1, num2;

        public double sum()
        {
            return num1 + num2;
        }
        public double subtract()
        {
            return num1 - num2;
        }
        public double product()
        {
            return num1 * num2;
        }
        public double divide()
        {
            return num1 / num2;
        }


    }
}