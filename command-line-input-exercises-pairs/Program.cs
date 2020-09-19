using System;

namespace command_line_input_exercises_pairs
{
    class Program
    {
        /*
        Write a command line program which prompts the user for the total bill, and the amount tendered. It should then display the change required.

        C:\Users> MakeChange

        Please enter the amount of the bill: 23.65
        Please enter the amount tendered: 100.00
        The change required is 76.35
        */
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter the amount of the bill");
            decimal totalBill = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the amount tendered");
            decimal tendered = decimal.Parse(Console.ReadLine());

            if (tendered < totalBill)
            {
                Console.WriteLine("Pay more money");
            }
            decimal change = tendered - totalBill;
            Console.WriteLine($"Your change is ${change}");

        }
    }
}
