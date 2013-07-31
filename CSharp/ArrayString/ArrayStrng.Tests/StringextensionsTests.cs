using ArrayString;
using Xunit;
using Xunit.Extensions;

namespace ArrayStrng.Tests
{
    public class StringextensionsTests
    {
        public class RemoveCharactersMethod
        {
            [Theory]
            [InlineData("")]
            [InlineData(" ")]
            public void WhenStringEmptyWhite_ReturnOriginalString(string val)
            {
                Assert.Equal(val, val.RemoveCharacters("a")); 
            }
            
            [Fact]
            public void IfStringWithCharsIsEmpty_ReturnOriginalString()
            {
                var inputString = "Test Of a string";

                Assert.Equal(inputString, inputString.RemoveCharacters(string.Empty));
            }

            [Fact]
            public void IfStringWithoutSpecifiedChars_ReturnOriginalString()
            {
                var inputString = "Test Of a string";

                Assert.Equal(inputString, inputString.RemoveCharacters("z"));
            }
        }

        public class FirstNonRepeatedCharacterMethod
        {
            [Theory]
            [InlineData("")]
            [InlineData(" ")]
            public void WhenStringEmptyWhite_ReturnNull(string val)
            {
               Assert.Null(val.FirstNonRepeatedChar()); 
            }

            [Fact]
            public void WhenStringWithSingleChar_ReturnThisChar()
            {
                var input = "c";

                var expectedChar = 'c';

                Assert.Equal(expectedChar, input.FirstNonRepeatedChar());
            }

            [Fact]
            public void WhenStringWithSingleChar_WithWhiteSpace_ReturnThisChar()
            {
                var input = "     c     ";

                var expectedChar = 'c';

                Assert.Equal(expectedChar, input.FirstNonRepeatedChar());
            }
            
            [Fact]
            public void WhenStringWithNotUniqueChars_Return_Null()
            {
                var input = "cc";

                Assert.Null(input.FirstNonRepeatedChar());
            }

            [Theory]
            [InlineData("abcd", 'a')]
            [InlineData("aabccd", 'b')]
            [InlineData("aabbccdd", null)]
            [InlineData("abcd", 'a')]
            [InlineData("xzcsqwe", 'x')]
            [InlineData("tetter", 'r')]
            public void SingleWordCase(string inputVal, char? resultChar)
            {
               Assert.Equal(resultChar, inputVal.FirstNonRepeatedChar()); 
            }

            [Theory]
            [InlineData("aaaaa bcd", 'b')]
            [InlineData("gogogogoog test", 'e')]
            public void MultiWordCase(string inputVal, char? resultChar)
            {
                Assert.Equal(resultChar, inputVal.FirstNonRepeatedChar());
            }
        }
    }
}