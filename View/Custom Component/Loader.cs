using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCenter.Viwe.Student
{
    public class Loader
    { 
        public  int width  , height ;
        public Loader(int _width, int _height)
        {
            this.width = _width;
            this.height = _height;
            panel.Top = height / 2;
            panel.Left = width / 2;
            panel.Controls.Add(pictureBox);
            
        }

        public  Panel panel = new ()
        {   
            Size = new Size(70, 70),
        };

        public PictureBox pictureBox = new()
        {
            Image = Resource1.loader,
            SizeMode = PictureBoxSizeMode.Zoom,
            Size = new Size(70,70),
            BackColor = Color.White,
            Dock = DockStyle.Fill,
            
        };

     
    }
}
