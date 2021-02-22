using System;
using System.Collections.Generic;
using System.Text;

namespace Study_210221
{
    class ScoreBoard
    {
        public int BingoScore = 0;
        public int BaseBallScore = 0;
        public int TotalScore = 0;


        public void OutputScore()
        {
            Console.WriteLine("빙고 스코어 : " + BingoScore);
            Console.WriteLine("야구 스코어 : " + BaseBallScore);
            Console.WriteLine("토탈 스코어 : " + TotalScore);
          
        }

  

    }
}
