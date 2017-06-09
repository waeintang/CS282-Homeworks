using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Vector
    {
        #region 屬性定義

        private double x;
        private double y;

        public double X { get; set; }

        private double Y { get; set; }

        public double Length
        {
            get
            { return Math.Sqrt(x * x + y * y); }
        }

        #endregion 屬性定義

        #region 建構式

        public Vector(double X, double Y)
        {
            this.X = X; // this.X =>  public class Vector's X
            this.Y = Y;
        }

        public Vector()
            : this(0, 0)
        {
        }

        public Vector(Vector vector)
            : this(vector.X, vector.Y)
        {
        }

        #endregion 建構式

        public void Print()
        {
            Console.WriteLine
               ("X:{0}, Y:{1}", this.X, this.Y);
        }
    }
}