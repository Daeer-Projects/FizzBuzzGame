using System.Globalization;

namespace FizzBuzzGame
{
    public class FizzBuzzKata : IFizzBuzzKata
    {
        #region Constants
        private const string Fizz = "fizz";
        private const string Buzz = "buzz";
        private const string FizzBuzz = "fizzbuzz";
        #endregion Constants

        /// <summary>
        /// Gives an answer to the current game.
        /// </summary>
        /// <param name="i">The current number in the game sequence.</param>
        /// <returns>The appropriate answer to the current number.</returns>
        public string Answer(int i)
        {
            bool isFizz = ((i%3) == 0);
            bool isBuzz = ((i%5) == 0);
            bool isFizzBuzz = (((i%3) == 0) && ((i%5) == 0));

            string answer = i.ToString(CultureInfo.InvariantCulture);
            
            if (isFizz)
            {
                answer = Fizz;
            }
            
            if (isBuzz)
            {
                answer = Buzz;
            }

            if (isFizzBuzz)
            {
                answer = FizzBuzz;
            }
            
            return answer;
        }

    }
}
