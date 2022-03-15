using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades
            studentGrades = new StudentGrades();

        private readonly int[] testMarks = new int[]
            {
                10, 20, 30, 40, 50,
                60, 70, 80, 90, 100
            };

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
            Grades actualGrade = app03.ConvertToGrade(110);
            Assert.AreEqual(actualGrade, Grades.X);
        }

        [TestMethod]
        public void TestCalculateMinimum()
        {
            studentGrades.Marks = testMarks;
            int expectedMinimum = 10;
            studentGrades.CalculateStatistics();
            Assert.AreEqual(expectedMinimum, studentGrades.Minimum);
        }

        [TestMethod]
        public void TestCalculateMaximum()
        {
            studentGrades.Marks = testMarks;
            int expectedMaximum = 100;
            studentGrades.CalculateStatistics();
            Assert.AreEqual(expectedMaximum, studentGrades.Maximum);
        }

        [TestMethod]
        public void TestCalculateMean()
        {
            studentGrades.Marks = testMarks;
            double expectedMean = 55.0;
            studentGrades.CalculateStatistics();
            Assert.AreEqual(expectedMean, studentGrades.Mean);
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            studentGrades.Marks = testMarks;
            bool expectedProfile = false;
            studentGrades.CalculateGradeProfile();
            expectedProfile = ((studentGrades.GradeProfile[0] == 3) &&
                               (studentGrades.GradeProfile[1] == 1) &&
                               (studentGrades.GradeProfile[2] == 1) &&
                               (studentGrades.GradeProfile[3] == 1) &&
                               (studentGrades.GradeProfile[4] == 4));
            Assert.IsTrue(expectedProfile);
        }
    }
}