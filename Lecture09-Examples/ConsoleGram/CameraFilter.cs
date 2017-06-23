using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    public abstract class CameraFilter:IFilter, CameraPlugin // 因為不知道怎麼做，所以要有 abstract 
    {
        public abstract string GetImage(string image);
    }
}
