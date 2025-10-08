using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    internal class Circle: Shape
    {

        int radius;
        public Circle(int x, int y, Color color, int radius) : base(x,y,color)
        {
            this.radius = radius;
        }
        public override void draw(Graphics g)
        {
            Pen p = new Pen(color, thickness);
            SolidBrush b = new SolidBrush(color);
            //fill with color
            g.FillEllipse(b, x - radius, y - radius, radius * 2, radius * 2);
            //draw outline
            g.DrawEllipse(p, x - radius, y - radius, radius * 2, radius * 2);

            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.NoClip; 
            String text = this.ToString();
            g.DrawString(text, drawFont, drawBrush, x - radius/2, y - radius/2, drawFormat);
        }
    }
}
