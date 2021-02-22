using System;
using System.Collections.Generic;
using System.Text;

namespace Study_210221
{
    class Bingo
    {
      
        public void Intro()
        {
            Console.WriteLine("이것은 빙고 게임입니다.");
            //Console.WriteLine(MyMath.Plus(2, 4));

        }

        public int AddScore(ScoreBoard scoreBoard)
        {
            int score = ++scoreBoard.BingoScore;
           

            //t result = mymath.Plus(scoreBoard.BingoScore, 12533);
            //Console.WriteLine("result : " + result);
            

            return score;


        }
    }
}
