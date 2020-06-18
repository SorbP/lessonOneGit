using LessonOne;
using NUnit.Framework;
using System.Reflection;
using static LessonOne.Program; 

namespace LessonOneTest
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ArrayHasExpectedInputValues()
        {
            Program.ArrayInput(0, 30);
            Program.ArrayInput(1, 20);
            Program.ArrayInput(2, 10);

            int[] testArray = Program.GetArray();

            Assert.AreEqual(30, testArray[0]);
            Assert.AreEqual(20, testArray[1]);
            Assert.AreEqual(10, testArray[2]);
        }

        [Test]
        public void ArrayHasExpectedInputValuesAfterSort()
        {
            TestArraySort(30, 20, 10, 10, 20, 30);
        }

        private void TestArraySort(int val1, int val2, int val3, int expect1, int expect2, int expect3)
        {
            Program.ArrayInput(0, val1);
            Program.ArrayInput(1, val2);
            Program.ArrayInput(2, val3);

            int[] testArray = Program.GetArray();

            Assert.AreEqual(expect3, testArray[0]);
            Assert.AreEqual(expect2, testArray[1]);
            Assert.AreEqual(expect1, testArray[2]);

            Program.SortArray();

            // testArray = Program.GetArray();


            Assert.AreEqual(expect1, testArray[0]);
            Assert.AreEqual(expect2, testArray[1]);
            Assert.AreEqual(expect3, testArray[2]);
        }
    }
}
