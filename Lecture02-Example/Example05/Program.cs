using System;

namespace Example05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "黃婉薇",
                Birthday = "1988-05-20",
                Email = "vicky@email.com",
                Orientation = 0.0,
                /*  Pos = new Position()
                  {
                      X_Axis = 10.0,
                      Y_Axis = 20.0
                  }*/
                Pos = Position.Generate()
            };
            //  正常做一次
            // person.ShowPosition();
            // person.MoveForward(100);
            // person.ShowPosition();
            // person.TurnRight(90);
            // person.MoveForward(100);
            // person.ShowPosition();

            /*跑4 次
            for (var count = 0; count < 10; count++)
            {
                person.MoveForward(100);
                person.TurnRight(90);
                person.ShowPosition();
            }
            */
            // 輸入寬度
            //  person.DrawSquare(200);

            Console.WriteLine("請輸入要畫的方形的邊長:");
            double width = 0.0;
            bool success = double.TryParse(Console.ReadLine(), out width); //檢查是否有輸入錯誤

            if (success)
                person.DrawSquare(width);
            else
                Console.WriteLine("GG 拉，請重新輸入");
        }
    }
}