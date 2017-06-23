using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    public class LomoFilter :CameraPlugin,  CameraFilter//CameraPlugin 類別寫在前面
    {

        public override string GetImage(string image)
        {
            return "這是Lomo 風格化後的圖片" + image;
        }
    }
}
