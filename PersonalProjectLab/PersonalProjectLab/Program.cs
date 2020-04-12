using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool NotQuit = true;
           
            while (NotQuit)
            {
                string input = "";
                string conversion;
                int temperature;

                input = GetInitialUnit("What is your initial temperature unit? [Fahrenheit] [Celsius] [Kelvin]");

                if (input == "Fahrenheit")
                {
                    Console.WriteLine("What unit would you like to convert to? [Celsius] [Kelvin]");
                    conversion = (Console.ReadLine());

                    if (conversion == "Celsius")
                    {
                        temperature = GetInitialTemperatureInteger("What is your initial temperature?");
                        
                        TempUnitConvert Convert = new TempUnitConvert();

                        double Celsius = Convert.CalculateFahrenheitToCelsius(temperature);

                        Console.WriteLine(Celsius + "°C");

                    }
                    if (conversion == "Kelvin")
                    {
                        temperature = GetInitialTemperatureInteger("What is your initial temperature?");

                        TempUnitConvert Convert = new TempUnitConvert();

                        double Kelvin = Convert.CalculateFahrenheitToKelvin(temperature);

                        Console.WriteLine(Kelvin+ "°K");
                    }
                }

                if (input == "Celsius")
                {
                    Console.WriteLine("What unit would you like to convert to? [Fahrenheit] [Kelvin]");
                    conversion = (Console.ReadLine());

                    if (conversion == "Fahrenheit")
                    {
                        temperature = GetInitialTemperatureInteger("What is your initial temperature?");

                        TempUnitConvert Convert = new TempUnitConvert();

                        double Fahrenheit = Convert.CalculateCelsiusToFahrenheit(temperature);

                        Console.WriteLine(Fahrenheit+ "°F");
                    }
                    if (conversion == "Kelvin")
                    {
                        temperature = GetInitialTemperatureInteger("What is your initial temperature?");

                        TempUnitConvert Convert = new TempUnitConvert();

                        double Kelvin = Convert.CalculateCelsiusToKelvin(temperature);

                        Console.WriteLine(Kelvin+ "°K");
                    }
                }


                if (input == "Kelvin")
                {
                    Console.WriteLine("What unit would you like to convert to? [Fahrenheit] [Celsius]");
                    conversion = (Console.ReadLine());

                    if (conversion == "Fahrenheit")
                    {
                        temperature = GetInitialTemperatureInteger("What is your initial temperature?");

                        TempUnitConvert Convert = new TempUnitConvert();

                        double Fahrenheit = Convert.CalculateKelvinToFahrenheit(temperature);

                        Console.WriteLine(Fahrenheit+ "°F");
                    }
                    if (conversion == "Celsius")
                    {
                        temperature = GetInitialTemperatureInteger("What is your initial temperature?");

                        TempUnitConvert Convert = new TempUnitConvert();

                        double Celsius = Convert.CalculateKelvinToCelsius(temperature);

                        Console.WriteLine(Celsius+ "°C");
                    }
                }

                Console.WriteLine("Do you want to continue? Yes: Press [1] No: Press [2]");
                string Decision = Console.ReadLine();
                if(Decision == "2")
                {
                    NotQuit = false;
                }
                else
                {
                    NotQuit = true; 
                }
           
            
            }   
            Console.WriteLine("Simulation Completed");
          
        }

        static string GetInitialUnit(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine(prompt);
            return (Console.ReadLine());

        }

        static int GetInitialTemperatureInteger(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine(prompt);
            return int.Parse(Console.ReadLine());
        }

        

        
    }
}