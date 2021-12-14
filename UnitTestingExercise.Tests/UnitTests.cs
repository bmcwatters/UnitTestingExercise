using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        private IEnumerable<object> expectedGreeting;

        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,25)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(25,5,5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GetHey()
        {
            //Arrange
            ChallengesSet01 challenger = new ChallengesSet01();
            //Act
            var actual = challenger.GetHey();
            //Assert
            Assert.Equal("HEY!", actual);
        }

        [Theory]
        [InlineData("Bob")]
        public void GetGreeting(string personName)
        {
            //Arrange
            ChallengesSet01 challenge = new ChallengesSet01();
            //Act
            var actual = challenge.GetGreeting(personName);
            //Assert
            Assert.Equal(expectedGreeting, actual);







        }
    }

    internal class ChallengesSet01
    {
        public ChallengesSet01()
        {
        }

        internal object GetGreeting(string personName)
        {
            throw new NotImplementedException();
        }

        internal object GetHey()
        {
            throw new NotImplementedException();
        }
    }
}
