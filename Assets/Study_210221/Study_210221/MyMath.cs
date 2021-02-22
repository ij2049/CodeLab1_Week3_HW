using System;
using System.Collections.Generic;
using System.Text;

namespace Study_210221
{
    class MyMath
    {
        private MyMath() { }      // 생성자 막음

        private static MyMath instance = null;



     
        public static MyMath Get()      // 통로 하나만 열어둠
        {
            if(instance == null)
            {
                instance = new MyMath();    // instance 비어 있다면 Mymath를 생성해라
            }

            return instance;
        }

       /* private static int nubmer = 0;       // instance

        public static int Add()
        {
            if(nubmer == 0)
            {
                nubmer = 10;
            }

            return nubmer;              //instance
        }*/




        public double Hypotenuse(float x1, float x2, float y1, float y2)
        {
            double a = Math.Pow((x1 - x2), 2);
            double b = Math.Pow((y1 - y2), 2);
            double c = Math.Sqrt(a + b);
            
            return c;
        }

        //두점 사이에 거리를 나타내는 함수
        public void Length(float x1, float y1, float x2, float y2, out float a, out float b)
        {
            a = Math.Abs(x1 - x2);
            b = Math.Abs(y1 - y2);
        }


        public int Plus(int a , int b)
        {
            return a + b;
        }

       public void Plus(int a, int b, out int c)
        {
            c = a + b;
        }
    }
}
