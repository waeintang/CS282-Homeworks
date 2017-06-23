using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
   public class Camera
    {
      public CameraPlugin plugin;
      // private IFilter filter;
       private string image = "原始圖片";
       public string GetImage()
       {
           if (plugin == null)
               return image;
           else
           {
               if (plugin is IFilter) // 看外掛是否濾鏡
               {
                   IFilter filter = plugin as IFilter;
                   return filter.GetImage(image);
               }
               else
               {
                   return image;
               }
           }

             
       }

    }
}
