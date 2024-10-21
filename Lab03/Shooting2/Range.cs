using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooting2
{
    internal class Range
    {
        private int totalScore;

        // prize, number of tokens by score
        private int wonTokens = 100;

        public Range(int initialScore = 0)
        {
            totalScore = initialScore;
        }

        public void AddScore(int score)
        {
            totalScore += score;
            Console.WriteLine("DEBUG updated score");
        }

        public int GetTotalScore()
        {
            return totalScore;
        }

        // score is internal
        public void PrintTotalScore()
        {
            Console.WriteLine($"RELEASE Total: {totalScore}. You're out.");
            Console.WriteLine($"RELEASE You won: ${totalScore * wonTokens}.");
        }
    }
}
