using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace StudentGradesTest
{
    [TestClass]
    public class GradesTests
    {
        [TestMethod]
        public void TestConvertLowestFail()
        {
            StudentGrades app03 = new StudentGrades();
            Grades actualGrade = app03.ConvertToGrade(0);
            Assert.AreEqual(actualGrade, Grades.F);
        }

        [TestMethod]
        public void TestConvertHighestFail()
        {
            StudentGrades app03 = new StudentGrades();
            Grades actualGrade = app03.ConvertToGrade(39);
            Assert.AreEqual(actualGrade, Grades.F);
        }

        [TestMethod]
        public void TestConvertLowestD()
        {
            StudentGrades app03 = new StudentGrades();
            Grades actualGrade = app03.ConvertToGrade(40);
            Assert.AreEqual(actualGrade, Grades.D);
        }

        [TestMethod]
        public void TestConvertHighestD()
        {
            StudentGrades app03 = new StudentGrades();
            Grades actualGrade = app03.ConvertToGrade(49);
            Assert.AreEqual(actualGrade, Grades.D);
        }

        [TestMethod]
        public void TestConvertLowestC()
        {
            StudentGrades app03 = new StudentGrades();
            Grades actualGrade = app03.ConvertToGrade(50);
            Assert.AreEqual(actualGrade, Grades.C);
        }

        [TestMethod]
        public void TestConvertHighestC()
        {
            StudentGrades app03 = new StudentGrades();
            Grades actualGrade = app03.ConvertToGrade(59);
            Assert.AreEqual(actualGrade, Grades.C);
        }

        [TestMethod]
        public void TestConvertLowestB()
        {
            StudentGrades app03 = new StudentGrades();
            Grades actualGrade = app03.ConvertToGrade(60);
            Assert.AreEqual(actualGrade, Grades.B);
        }

        [TestMethod]
        public void TestConvertHighestB()
        {
            StudentGrades app03 = new StudentGrades();
            Grades actualGrade = app03.ConvertToGrade(69);
            Assert.AreEqual(actualGrade, Grades.B);
        }

        [TestMethod]
        public void TestConvertLowestA()
        {
            StudentGrades app03 = new StudentGrades();
            Grades actualGrade = app03.ConvertToGrade(70);
            Assert.AreEqual(actualGrade, Grades.A);
        }

        [TestMethod]
        public void TestConvertHighestA()
        {
            StudentGrades app03 = new StudentGrades();
            Grades actualGrade = app03.ConvertToGrade(100);
            Assert.AreEqual(actualGrade, Grades.A);
        }

        [TestMethod]
        public void TestConvertX()
        {
            StudentGrades app03 = new StudentGrades();
            Grades actualGrade = app03.ConvertToGrade(109);
            Assert.AreEqual(actualGrade, Grades.X);
        }
    }
}