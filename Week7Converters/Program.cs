using System;

namespace Week7Converters
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp that converts
             * Fahrenheit into Celcius and vice versa.
             * -The program enables the user to select
             * if the user wants to convert into celcius 
             * or into Farenheit
             * - After the user has made their choice,
             * the program asks for an input,
             * performs calculations and
             * displays the result
             * - fahrenheit = (celsius * 9) / 5+32;
             * - celsius = (fahrenheit - 32) * 5 / 9;
             */
            Console.WriteLine("Do you wish to convert a number into Fahrenheit or Celcius or vice versa?");
            string UserInput = Console.ReadLine().ToLower();
            int Fahrenheit, Celcius;
            

            if (UserInput == "fahrenheit")
            {
                Console.WriteLine("Enter the temperature in Celsius (°C): ");
                Celcius = int.Parse(Console.ReadLine());
                Fahrenheit = (Celcius * 9) / 5 + 32;
                Console.WriteLine("The temperature in Fahrenheit is(°F) : " + Fahrenheit);
            } else if (UserInput == "celcius")
            {
                Console.WriteLine("Enter the temperature in Fahrenheit (°F): ");
                Fahrenheit = int.Parse(Console.ReadLine());
                Celcius = (Fahrenheit - 32) * 5 / 9;
                Console.WriteLine("The temperature in Celsius is(°C) : " + Celcius);
            }else
            {
                Console.WriteLine("Soooo, you feel like writing what I actually asked of you?");
            }

        }



    }
}
