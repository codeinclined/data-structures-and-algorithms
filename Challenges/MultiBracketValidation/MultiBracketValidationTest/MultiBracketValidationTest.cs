using System;
using Xunit;
using MultiBracketValidation;

namespace MultiBracketValidationTest
{
    public class MultiBracketValidationTest
    {
        [Theory]
        [InlineData("{}", true)]
        [InlineData("()[[Extra Characters]]", true)]
        [InlineData("(){}[[]]", true)]
        [InlineData("{}(Code)[Fellows](())", true)]
        [InlineData("(])", false)]
        [InlineData("[(])", false)]
        [InlineData("{[(])", false)]
        [InlineData("{foo)[bar}", false)]
        [InlineData("{end}[not](closed", false)]
        [InlineData("This string has no brackets! Such wow! Very unit test!", true)]
        public void MultiBracketValidationTests(string input, bool expectedResult)
        {
            // Act
            bool actualResult = Program.MultiBracketValidation(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
