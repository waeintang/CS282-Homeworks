using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    public class Position
    {
        public double X_Axis;
        public double Y_Axis;

        private static Random random; //pos. 不會出現random

        public static Position Generate()
        {
            if (Position.random == null)
                random = new Random();
            return new Position()
            {
                X_Axis = random.Next(-100, 101),
                Y_Axis = random.Next(-100, 101)
            };
        }


    }
}
