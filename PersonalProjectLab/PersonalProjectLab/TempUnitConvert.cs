using System;
namespace PersonalProjectLab
{
    public class TempUnitConvert
    {

        public TempUnitConvert()
        {

        }

        public double CalculateFahrenheitToCelsius(int Fahrenheit)
        {

            double Celsius;

            Celsius = (5 * (Fahrenheit - 32)) / 9;

            return Celsius;

        }

        public double CalculateFahrenheitToKelvin(int Fahrenheit)
        {

            double Kelvin;

            Kelvin = (5 * (Fahrenheit + 459.67)) / 9;

            return Kelvin;

        }

        public double CalculateCelsiusToFahrenheit(int Celsius)
        {
            double Fahrenheit;
            
            Fahrenheit = (Celsius * 9) / 5 + 32;

            return Fahrenheit;

        }

        public double CalculateCelsiusToKelvin(int Celsius)
        {
            double Kelvin;

            Kelvin = Celsius + 273.15;

            return Kelvin;
        }

        public double CalculateKelvinToFahrenheit(int Kelvin)
        {
            double Fahrenheit;

            Fahrenheit = (Kelvin * 9) / 5 - 459.67;

            return Fahrenheit;
        }

        public double CalculateKelvinToCelsius(int Kelvin)
        {
            double Celsius;

            Celsius = Kelvin - 273.15;

            return Celsius;
        }
    }
    
  
}




