using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;


namespace shape
{
    /// <summary>
    /// 椭圆类
    /// </summary>
    class Ellipse : Shape
    {

        private float _SemiMajorAxis;
        private float _SemiMinorAxis;

        public float SemiMajorAxis { get => _SemiMajorAxis; set => _SemiMajorAxis = value; }
        public float SemiMinorAxis { get => _SemiMinorAxis; set => _SemiMinorAxis = value; }

        public override double Area()
        {
            return SemiMajorAxis * SemiMinorAxis * Math.PI; 
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * SemiMinorAxis + 4 * (SemiMajorAxis - SemiMinorAxis); ;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(Color, LineWidth), Position.X, Position.Y, SemiMajorAxis, SemiMinorAxis);
        }
    }
}
