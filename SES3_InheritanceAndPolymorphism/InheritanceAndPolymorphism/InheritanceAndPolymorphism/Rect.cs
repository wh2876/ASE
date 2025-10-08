using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    internal class Rect : Shape
    {
        int w, h;
        public Rect(int x, int y, Color color, int w, int h) : base(x, y, color)
        {
            this.w = w;
            this.h = h;
        }

        public override void draw(Graphics g)
        {
            Pen p = new Pen(color, thickness);
            SolidBrush b = new SolidBrush(color);
            //fill with color
            g.FillRectangle(b, x, y, w, h);
            //draw outline
            g.DrawRectangle(p, x, y, w, h);

            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.NoClip;
            String text = this.ToString();
            g.DrawString(text, drawFont, drawBrush, x + w / 2, y + h / 2, drawFormat);
        }
    }
}
