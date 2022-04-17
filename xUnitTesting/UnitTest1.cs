using System;
using Xunit;
using ckennedy8728_A1;
using System.Linq;

namespace xUnitTesting
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(101, "5")]
        public void IsBinaryTest(int input, string expectedResult)
        {
            string actualResult = "";
            int binary = input;
            int decimalOutput = 0;
            
            int baseValue = 1;

            while (binary > 0)
            {
                int remainder = binary % 10;
                binary = binary / 10;
                decimalOutput += remainder * baseValue;
                baseValue = baseValue * 2;
            }

            actualResult = Convert.ToString(decimalOutput);

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(5, "101")]
        public void IsDecimalTest(int input, string expectedResult)
        {
            int numEntry = input;

            int val;
            string actualResult = "";

            while (numEntry >= 1)
            {
                val = numEntry / 2;
                actualResult += (numEntry % 2).ToString();
                numEntry = val;
            }

            string binaryConversion = "";
            for (int i = actualResult.Length - 1; i >= 0; i--)
            {
                binaryConversion = binaryConversion + actualResult[i];
            }

            actualResult = binaryConversion;

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData("abc", "cba")]
        public void IsReveresed(string input, string expectedResult) 
        {
            string entry = input;

            string actualResult = "";

            string reverseEntry = string.Join(" ", entry.Split(' ').Select(s => new String(s.Reverse().ToArray())));
            actualResult = reverseEntry;

            Assert.Equal(expectedResult, actualResult);
            
        }
    }
}
