using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public class Scene
    {
        public int Number;
        public PictureBox TargetPictureBox;

        public Scene(PictureBox target)
        {
            this.Number = 1;
            this.TargetPictureBox = target;
            this.TargetPictureBox.Image = this.GetImage();
        } // public Scene(int number)

        public Image GetImage()
        {
            if (this.Number == 1)
                return global::Example01.Properties.Resources._1;
            else if (this.Number == 2)
                return global::Example01.Properties.Resources._2;
            else if (this.Number == 3)
                return global::Example01.Properties.Resources._3;
            else if (this.Number == 4)
                return global::Example01.Properties.Resources._4;
            else if (this.Number == 5)
                return global::Example01.Properties.Resources._5;
            else if (this.Number == 6)
                return global::Example01.Properties.Resources._6;
            else if (this.Number == 7)
                return global::Example01.Properties.Resources._7;
            else if (this.Number == 8)
                return global::Example01.Properties.Resources._8;
            else if (this.Number == 9)
                return global::Example01.Properties.Resources._9;
            else
                return global::Example01.Properties.Resources._10;
            //this.TargetPicture.Image = (Image)
            /*
            for (int i = 0; i < 2; i++)
            {
                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + i);
            }*/
        } //public Image GetImage()

        public void ChangeTo(int target)
        {
            this.Number = target;
            this.TargetPictureBox.Image = this.GetImage();
        } // public void ChangeTo(int target)
    }//public class Scene
}//namespace Example01