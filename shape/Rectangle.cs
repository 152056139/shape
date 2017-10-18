using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace shape
{
    class Rectangle : Shape
    {
        private int _height;
        private int _Widht;

        public int Height { get => _height; set => _height = value; }
        public int Widht { get => _Widht; set => _Widht = value; }

        public override double Area()
        {
            throw new NotImplementedException();
        }

        public override void Draw(Graphics graphics)
        {
            throw new NotImplementedException();
        }

        public override double Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}
