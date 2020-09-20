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
/*
 * 
 * 
 * 
 * 
 * Console.WriteLine("Welcome to the Martian weight Converter.");       //start here 
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            char cont = 'J';
                do
                {
                    Console.WriteLine("Please enter your weight on Earth:( More than one if neccessary, just put a space between each one)");
                    string eW = Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    char[] delimiters = { ' ' };
                    string[] weighArray = eW.Split(delimiters,StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < weighArray.Length; i++)
                    {
                        decimal oriW = decimal.Parse(weighArray[i]);
                        decimal mW = oriW * 0.378M;
                        Console.WriteLine($" Earth weight is {oriW} lbs. | Martian weight is {mW} lbs.");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" Did you want to enter any  more weights?");
                    cont = Char.Parse(Console.ReadLine());
                    if (cont != 'y' || cont != 'Y' || cont != 'n' || cont != 'N') 
                    {
                        Console.WriteLine(" (Y) for yes or (N) for no.");
                        cont = char.Parse(Console.ReadLine());
                    }
                    


                } 
            while ((cont == 'y') || (cont == 'Y'));
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Thats all folks. Thanks for using our Converter. Have a fun time on Mars! Bon Voyage!!!!");
*/