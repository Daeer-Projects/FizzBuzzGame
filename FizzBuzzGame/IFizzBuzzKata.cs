using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    public interface IFizzBuzzKata
    {
        /// <summary>
        /// Give an answer to the current game.
        /// </summary>
        /// <param name="number">The current number in the game sequence.</param>
        /// <returns>The appropriate answer to the current number.</returns>
        string Answer(int number);
    }
}
