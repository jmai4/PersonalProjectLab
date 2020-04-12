using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class TempConvertTests
    {
        [TestMethod]
        public void FToC()
        {
            //arrange
            TempUnitConvert convert = new TempUnitConvert();

            //act
            double Celsius = convert.CalculateFahrenheitToCelsius(32);

            //assert
            Assert.AreEqual(0, Celsius);

        }
        [TestMethod]
        public void FToK()
        {
            //arrange
            TempUnitConvert convert = new TempUnitConvert();

            //act
            double Kelvin = convert.CalculateFahrenheitToKelvin(32);

            //assert
            Assert.AreEqual(273.15, Kelvin);

        }
        [TestMethod]
        public void CToF()
        {
            //arrange
            TempUnitConvert convert = new TempUnitConvert();

            //act
            double Fahrenheit = convert.CalculateCelsiusToFahrenheit(0);

            //assert
            Assert.AreEqual(32, Fahrenheit);
        }

        [TestMethod]
        public void CToK()
        {
            //arrange
            TempUnitConvert convert = new TempUnitConvert();

            //act
            double Kelvin = convert.CalculateCelsiusToKelvin(0);

            //assert
            Assert.AreEqual(273.15, Kelvin);
        }

        [TestMethod]
        public void KToF()
        {
            //arrange
            TempUnitConvert convert = new TempUnitConvert();

            //act
            double Fahrenheit = convert.CalculateKelvinToFahrenheit(0);

            //assert
            Assert.AreEqual(-459.67, Fahrenheit);
        }
        [TestMethod]
        public void KToC()
        {
            //arrange
            TempUnitConvert convert = new TempUnitConvert();

            //act
            double Celsius = convert.CalculateKelvinToCelsius(0);

            //assert
            Assert.AreEqual(-273.15, Celsius);
        }
    }
}
