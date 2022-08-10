using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData ("horse", true)]
        [InlineData("bye", false)]
        public void Test1(string word, bool expected)
        {
            //Arrange
            var newtest = new WordSmith();
            

            //Actual
           var actual = newtest.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
            
        }
    }
}
