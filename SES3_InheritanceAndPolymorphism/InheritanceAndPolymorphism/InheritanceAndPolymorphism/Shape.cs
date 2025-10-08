using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace InheritanceAndPolymorphism
{
    internal class Shape
    {

        protected int x;
        protected int y;

        protected Color color;
        protected int thickness = 20;
        public Shape(int x, int y, Color color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public virtual void draw(Graphics g)
        {

            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.NoClip;
            String text = "Shape";
            g.DrawString(text, drawFont, drawBrush, x, y, drawFormat);
        }
    }
}
