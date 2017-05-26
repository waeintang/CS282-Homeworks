using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
   public class Person
    {
        public string Name;
        public string Birthday;
        public string Email;
        public Position Pos;
        public double Orientation; //角度

        public void MoveForward(double distance) //往前走
        {
            Pos.X_Axis = Pos.X_Axis + distance * Math.Cos
                (Orientation * Math.PI / 180.0);
            Pos.Y_Axis = Pos.Y_Axis + distance * Math.Sin
                (Orientation * Math.PI / 180.0);
        }

        public void TurnRight(double angle)
        {
            Orientation = Orientation + angle;

        }

        public void ShowPosition()
        {
            Console.WriteLine("{0}的位置:({1},{2} 方位:{3},度)", Name, Pos.X_Axis, Pos.Y_Axis, Orientation);
        }

        public void DrawSquare(double width) // 帶入 寬度 畫方塊
        {

            for (var count = 0; count < 10; count++)
            {
                this.MoveForward(width);
                this.TurnRight(90);
                this.ShowPosition();
            }
        }

        public void DrawSquare() // 不帶入寬度就會default 為100, default 畫100 的方塊
        {
            DrawSquare(100);
        }
    }
}
