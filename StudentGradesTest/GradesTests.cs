using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace StudentGradesTest
{
    [TestClass]
    public class GradesTests
    {
        [TestMethod]
        public void TestConvertHighestFail()
        {
            StudentGrades app03 = new StudentGrades();
            Grades actualGrade = app03.ConvertToGrades(39);
            Assert.AreEqual(actualGrade, Grades.F);
        }
    }
}