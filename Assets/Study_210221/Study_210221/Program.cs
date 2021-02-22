using System;

namespace Study_210221
{
    class Program
    {
        static void Main(string[] args)
        {

            ScoreBoard scoreBoard = new ScoreBoard();

            Bingo bingo = new Bingo();
            Baseball baseball = new Baseball(scoreBoard);

           //MyMath myMath = new MyMath(); // 외부에서 생성을 안되게 하고 싶다!!


            MyMath.Get().Plus(7, 5);
            MyMath.Get().Plus(7, 5);


            int choice;

            while (true)
            {
                Console.WriteLine("게임을 선택하세요.");
                Console.WriteLine("1번 빙고 게임 / 2번 야구 게임");
                Console.Write("입력 : ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice == 1)
                    {
                        bingo.Intro();
                        Console.WriteLine("빙고게임 스코어 : " + bingo.AddScore(scoreBoard));

                    }
                    else if (choice == 2)
                    {
                        baseball.Intro();
                        Console.WriteLine("야구게임 스코어 : " + baseball.AddScore());
                    }
                    else if(choice == 3)
                    {
                        //ScoreBoard scoreBoard = new ScoreBoard();

                    }

                }
                else
                {
                    Console.WriteLine("잘못 입력하셨습니다.");
                }

                Console.WriteLine();
                Console.WriteLine();
            }




            //tryparse ==

            // 게임을 선택하세요
            // 1번 빙고 게임 / 2번 야구게임
            // 입력 : 

        }
    }

}
