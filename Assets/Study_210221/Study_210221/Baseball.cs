using System;
using System.Collections.Generic;
using System.Text;

namespace Study_210221
{
    class Baseball
    {
        ScoreBoard scoreBoard;
      

        public Baseball(ScoreBoard scoreBoard)
        {
            this.scoreBoard = scoreBoard;
        }

        

        public void Intro ()
        {
            Console.WriteLine("이것은 야구게임입니다.");

            //intt result = mymath.Plus(2325, 12533);
            //Console.WriteLine("result : " + result);

            // MyMath.Plus(10, 6);
            int reseult = MyMath.Get().Plus(10, 5);
            Console.WriteLine(reseult);
        }

        public int AddScore()
        {
            int score = ++scoreBoard.BaseBallScore; //전위연산

            return score;
        }

        public void AddTotalScore()
        {
            int score = ++scoreBoard.TotalScore;
        }
    }
}
