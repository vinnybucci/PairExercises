using System;

namespace MartianWeight
{
    /*
    In case you've ever pondered how much you weight on Mars, here's the calculation:
    Wm = We* 0.378
    where 'Wm' is the weight on Mars, and 'We' is the weight on Earth

    Write a command line program which accepts a series of Earth weights from the user  
    and displays each Earth weight as itself, and its Martian equivalent.


    C:\Users> MartianWeight  
    Enter a series of Earth weights (space-separated): 98 235 185

    98 lbs.on Earth, is 37 lbs.on Mars.
    235 lbs.on Earth, is 88 lbs.on Mars.
    185 lbs.on Earth, is 69 lbs.on Mars. 
    */
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" please enter your weight on Earth:");
            string  eW = Console.ReadLine();
            char[] delimiters = { ' ' };
            string[] weighArray = eW.Split(delimiters);
            for (int i = 0; i < weighArray.Length; i++)
            {
                decimal oriW = decimal.Parse(weighArray[i]);
                decimal mW = oriW * 0.378M;

                Console.WriteLine($" Earth weight is {oriW} lbs. | Martian weight is {mW} lbs.");
            }









            Console.WriteLine("program over !");
        }
    }
}
