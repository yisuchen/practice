using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace pratice1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SingleNumberTest_4_1_2_1_2_5_5()
        {
            // arrange
            Program target = new Program();
            int[] nums = new int[] { 4, 1, 2, 1, 2, 5, 5 };
            int expect = 4;
            int actual;
            // act
            actual = target.SingleNumber(nums);
            // assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void SingleNumberTest_2_2_1()
        {
            // arrange
            Program target = new Program();
            int[] nums = new int[] { 2, 2, 1 };
            int expect = 1;
            int actual;
            // act
            actual = target.SingleNumber(nums);
            // assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void SingleNumberTest_4_1_2_1_2()
        {
            // arrange
            Program target = new Program();
            int[] nums = new int[] { 4, 1, 2, 1, 2 };
            int expect = 4;
            int actual;
            // act
            actual = target.SingleNumber(nums);
            // assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void IsPowerOfThreeTest_27()
        {
            // arrange
            Program target = new Program();
            int num = 27;
            bool expect = true;
            bool actual;
            // act
            actual = target.IsPowerOfThree(num);
            // assert
            Assert.AreEqual(actual, expect);
        }
        [TestMethod()]
        public void IsPowerOfThreeTest_45()
        {
            // arrange
            Program target = new Program();
            int num = 45;
            bool expect = false;
            bool actual;
            // act
            actual = target.IsPowerOfThree(num);
            // assert
            Assert.AreEqual(actual, expect);
        }
        [TestMethod()]
        public void IsPowerOfThreeTest_9()
        {
            // arrange
            Program target = new Program();
            int num = 9;
            bool expect = true;
            bool actual;
            // act
            actual = target.IsPowerOfThree(num);
            // assert
            Assert.AreEqual(actual, expect);
        }
        [TestMethod()]
        public void IsPowerOfThreeTest_0()
        {
            // arrange
            Program target = new Program();
            int num = 0;
            bool expect = false;
            bool actual;
            // act
            actual = target.IsPowerOfThree(num);
            // assert
            Assert.AreEqual(actual, expect);
        }

        [TestMethod()]
        public void MoveZeroesTest_0_12_0_1_3()
        {
            // arrange
            Program target = new Program();
            bool result = false;
            // act
            int[] nums = new int[] { 0, 12, 0, 1, 3 };
            int[] expect = new int[] { 12, 1, 3, 0, 0 };
            int[] actual;
            // assert
            actual = target.MoveZeroes(nums);
            for (var i = 0; i < nums.Length; i++)
            {
                if (expect[i] == actual[i])
                    result = true;
                else
                    result = false;
            }
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void MoveZeroes2Test_0_12_0_1_3_5_4_3()
        {
            // arrange
            Program target = new Program();
            bool result = false;
            // act
            int[] nums = new int[] { 0, 12, 0, 1, 3, 5, 4, 3 };
            int[] expect = new int[] { 12, 1, 3, 5, 4, 3, 0, 0 };
            int[] actual;
            // assert
            actual = target.MoveZeroes2(nums);
            for (var i = 0; i < nums.Length; i++)
            {
                if (expect[i] == actual[i])
                    result = true;
                else
                    result = false;
            }
            Assert.IsTrue(result);
        }
    }
}