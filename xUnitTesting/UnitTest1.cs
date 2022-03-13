using System;
using Xunit;
using ckennedy8728_A1;

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
    }
}
