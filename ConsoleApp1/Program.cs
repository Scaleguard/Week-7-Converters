using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            


            int Celsius, Fahrenheit, UserChoice;


            Console.SetCursorPosition(15, 0);
            Console.WriteLine("Welcome to the Temperature Converter!");
            Console.WriteLine("");
            Console.WriteLine("");
            
            Console.ReadLine();
            Console.Clear();




            Console.SetCursorPosition(0, 9);
            Console.WriteLine("Please Enter one of the provided options from above");
            UserChoice = Convert.ToInt16(Console.ReadLine());

            Console.Clear();


            // Convert Celsius to Fahrenheit.
            if (UserChoice == 1)
            {
                Console.SetCursorPosition(20, 0);
                Console.WriteLine("Converting Celsius To Fahrenheit");

                Console.SetCursorPosition(0, 4);
                Console.WriteLine("Enter the Temperature in Celsius(°C) : ");
                Celsius = int.Parse(Console.ReadLine());
                Fahrenheit = (Celsius * 9) / 5 + 32;
                Console.WriteLine("The temperature in Fahrenheit is(°F) : " + Fahrenheit);


                if (Fahrenheit <= -50)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                }
                if (Fahrenheit <= -10)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                if (Fahrenheit == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (Fahrenheit >= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (Fahrenheit >= 50)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.ReadLine();



                }


                // Convert Fahrenheit to Celsius.

                if (UserChoice == 2)
                {
                    Console.SetCursorPosition(20, 0);
                    Console.WriteLine("Converting Fahrenheit To Celsius");

                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine("Enter the Temperature in Fahrenheit(°F) : ");
                    Fahrenheit = int.Parse(Console.ReadLine());
                    Celsius = (Fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("The temperature in Celsius is(°C) : " + Celsius);

                    if (Celsius <= -50)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (Celsius <= -10)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    if (Celsius == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    if (Celsius >= 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (Celsius >= 50)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.ReadLine();


                        //Exit

                        if (UserChoice != 3)
                        {

                            Console.ReadLine();

                            //Help Facility

                            if (UserChoice == 4)
                            {
                                Console.SetCursorPosition(20, 0);
                                Console.WriteLine("Welcome to the Temperature Calculator Help Facility");
                                Console.WriteLine("");

                                Console.ReadLine();
                            }


                            {




                            }
                        }
                    }
                }
            }
        }
    }
}
