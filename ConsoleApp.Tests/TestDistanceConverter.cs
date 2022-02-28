using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestCentimetresToInches()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Centimetres;
                converter.ToUnit = DistanceUnits.Inches;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 0.393701;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestInchesToCentimetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Inches;
                converter.ToUnit = DistanceUnits.Centimetres;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 2.5399986284007405;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestInchesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Inches;
                converter.ToUnit = DistanceUnits.Feet;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 0.08333333333333333;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestFeetToInches()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Feet;
                converter.ToUnit = DistanceUnits.Inches;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 12.0;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestInchesToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Inches;
                converter.ToUnit = DistanceUnits.Metres;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 0.025399986284007407;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestMetresToInches()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Metres;
                converter.ToUnit = DistanceUnits.Inches;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 39.3701;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestInchesToKilometres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Inches;
                converter.ToUnit = DistanceUnits.Kilometres;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 2.539998628400741E-05;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestKilometresToInches()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Kilometres;
                converter.ToUnit = DistanceUnits.Inches;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 39370.1;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestInchesToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Inches;
                converter.ToUnit = DistanceUnits.Miles;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 1.5782828282828283E-05;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestMilesToInches()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Miles;
                converter.ToUnit = DistanceUnits.Inches;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 63360;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestCentimetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Centimetres;
                converter.ToUnit = DistanceUnits.Feet;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 0.03280839895013123;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestFeetToCentimetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Feet;
                converter.ToUnit = DistanceUnits.Centimetres;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 30.48;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestCentimetresToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Centimetres;
                converter.ToUnit = DistanceUnits.Metres;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 0.01;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestMetresToCentimetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Metres;
                converter.ToUnit = DistanceUnits.Centimetres;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 100;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestCentimetresToKilometres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Centimetres;
                converter.ToUnit = DistanceUnits.Kilometres;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 1E-05;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestKilometresToCentimetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Kilometres;
                converter.ToUnit = DistanceUnits.Centimetres;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 100000;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestCentimetresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Centimetres;
                converter.ToUnit = DistanceUnits.Miles;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 6.213727366498068E-06;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestMilesToCentimetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Miles;
                converter.ToUnit = DistanceUnits.Centimetres;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 160934;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestFeetToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Feet;
                converter.ToUnit = DistanceUnits.Metres;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 0.3047999902464003;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestMetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Metres;
                converter.ToUnit = DistanceUnits.Feet;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 3.28084;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestFeetToKilometres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Feet;
                converter.ToUnit = DistanceUnits.Kilometres;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 0.0003047999902464003;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestKilometresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Kilometres;
                converter.ToUnit = DistanceUnits.Feet;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 3280.84;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Feet;
                converter.ToUnit = DistanceUnits.Miles;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 0.0001893939393939394;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Miles;
                converter.ToUnit = DistanceUnits.Feet;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 5280;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestMetresToKilometres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Metres;
                converter.ToUnit = DistanceUnits.Kilometres;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 0.001;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestKilometresToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Kilometres;
                converter.ToUnit = DistanceUnits.Metres;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 1000;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestMetresToMiles()
        { 
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Metres;
                converter.ToUnit = DistanceUnits.Miles;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 0.0006213727366498068;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestMilesToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Miles;
                converter.ToUnit = DistanceUnits.Metres;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 1609.34;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestKilometresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Kilometres;
                converter.ToUnit = DistanceUnits.Miles;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 0.621371;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }

        [TestMethod]
        public void TestMilesToKilometres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.FromUnit = DistanceUnits.Miles;
                converter.ToUnit = DistanceUnits.Kilometres;

                converter.FromDistance = 1.0;
                converter.CalculateDistance();

                double expectedDistance = 1.6093444978925633;

                Assert.AreEqual(expectedDistance, converter.ToDistance);
            }
        }
    }
}