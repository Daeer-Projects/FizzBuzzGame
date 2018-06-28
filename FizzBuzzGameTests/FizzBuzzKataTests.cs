using Xunit;
using FizzBuzzGame;

namespace FizzBuzzGameTests
{
    public class FizzBuzzKataTests
    {
        [Fact]
        public void AnswerReturnsFizzForThree()
        {
            // Arrange
            IFizzBuzzKata fizzBuzzKata = new FizzBuzzKata();

            // Act

            // Assert
            Assert.Equal("fizz", (fizzBuzzKata.Answer(3)));
        }

        [Fact]
        public void AnswerDoesNotReturnFizzForTwo()
        {
            // Arrange
            IFizzBuzzKata fizzBuzzKata = new FizzBuzzKata();

            // Act

            // Assert
            Assert.NotEqual("fizz", (fizzBuzzKata.Answer(2)));
        }

        [Fact]
        public void AnswerReturnsTwoForTwo()
        {
            // Arrange
            IFizzBuzzKata fizzBuzzKata = new FizzBuzzKata();

            // Act

            // Assert
            Assert.Equal("2", (fizzBuzzKata.Answer(2)));
        }

        [Fact]
        public void AnswerReturnsBuzzForFive()
        {
            // Arrange
            IFizzBuzzKata fizzBuzzKata = new FizzBuzzKata();

            // Act

            // Assert
            Assert.Equal("buzz", (fizzBuzzKata.Answer(5)));
        }

        [Fact]
        public void AnswerDoesNotReturnBuzzForFour()
        {
            // Arrange
            IFizzBuzzKata fizzBuzzKata = new FizzBuzzKata();

            // Act

            // Assert
            Assert.NotEqual("buzz", (fizzBuzzKata.Answer(4)));
        }

        [Fact]
        public void AnswerReturnsFizzForNine()
        {
            // Arrange
            IFizzBuzzKata fizzBuzzKata = new FizzBuzzKata();

            // Act

            // Assert
            Assert.Equal("fizz", (fizzBuzzKata.Answer(9)));
        }

        [Fact]
        public void AnswerReturnsBuzzForTen()
        {
            // Arrange
            IFizzBuzzKata fizzBuzzKata = new FizzBuzzKata();

            // Act

            // Assert
            Assert.Equal("buzz", (fizzBuzzKata.Answer(10)));
        }

        [Fact]
        public void AnswerReturnsFizzBuzzForFifteen()
        {
            // Arrange
            IFizzBuzzKata fizzBuzzKata = new FizzBuzzKata();

            // Act

            // Assert
            Assert.Equal("fizzbuzz", (fizzBuzzKata.Answer(15)));
        }
    }
}
