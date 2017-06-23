using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    public class BeautifyFacePlugin : CameraPlugin, CameraFilter
    {
        public string GetImae(string image)
        {
            return "美顏後的" + image;
        }
    }
}
