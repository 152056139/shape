using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    /// <summary>
    /// 圆类
    /// </summary>
    class Circle : Ellipse
    {
        private float _radiu;

        public float Radiu
        {
            set
            {
                SemiMajorAxis = value;
                SemiMinorAxis = value;
            }
            get
            {
                return SemiMajorAxis;
            }
        }

        public override double Area()
        {
            return Math.PI * Radiu * Radiu;
        }

        public override double Perimeter()
        {
            return Math.PI * 2 * Radiu; 
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(Color, LineWidth), Position.X, Position.Y, Radiu, Radiu);
        }
    }
}
