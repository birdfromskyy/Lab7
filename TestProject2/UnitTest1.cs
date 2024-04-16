using System;
namespace ConsoleApp1
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 5, 9, 2, 7, 1 }, new int[] { 1, 2, 5, 7, 9 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 5 }, new int[] { 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        public void Sort_Test(int[] inputArray, int[] expectedArray)
        {
            Functions.Sort(inputArray);
            Assert.AreEqual(expectedArray, inputArray);
        }

        [TestCase("radar", true)]
        [TestCase("level", true)]
        [TestCase("hello", false)]
        [TestCase("", false)]
        [TestCase("A man a plan a canal Panama", true)]
        public void IsPalindrome_Test(string inputString, bool expectedResult)
        {
            bool result = Functions.IsPalindrome(inputString);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(5, 120)]
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(10, 3628800)]
        [TestCase(20, 2432902008176640000)]
        public void Factorial_Test(int n, long expectedResult)
        {
            long result = Functions.Factorial(n);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(10, 55)]
        [TestCase(20, 6765)]
        public void CalculateFibonacci_Test(int n, int expectedResult)
        {
            int result = Functions.CalculateFibonacci(n);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("hello world", "world", 6)]
        [TestCase("abcdefg", "def", 3)]
        [TestCase("hello", "hi", -1)]
        [TestCase("", "empty", -1)]
        [TestCase("abcde", "", 0)]
        public void Search_Test(string text, string pattern, int expectedResult)
        {
            int result = Functions.Search(text, pattern);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(17, true)]
        [TestCase(20, false)]
        public void IsPrime_Test(int number, bool expectedResult)
        {
            bool result = Functions.IsPrime(number);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(123, 321)]
        [TestCase(123456, 654321)]
        [TestCase(-123, -321)]
        [TestCase(0, 0)]
        [TestCase(1534236469, 0)] // Overflow case
        public void Reverse_Test(int x, int expectedResult)
        {
            int result = Functions.Reverse(x);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(1, "I")]
        [TestCase(10, "X")]
        [TestCase(999, "CMXCIX")]
        [TestCase(3999, "MMMCMXCIX")]
        [TestCase(4000, "")]
        public void IntToRoman_Test(int num, string expected)
        {
            string result = Functions.IntToRoman(num);
            Assert.AreEqual(expected, result);
        }
    }
}
