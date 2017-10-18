using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace shape
{
    /// <summary>
    /// 所有图形的基类
    /// </summary>
    abstract class Shape
    {
        private string _Name;
        private Point _Position;
        private Color _Color;
        private float _LineWidth;

        public string Name { get => _Name; set => _Name = value; }
        public Point Position { get => _Position; set => _Position = value; }
        public Color Color { get => _Color; set => _Color = value; }
        public float LineWidth { get => _LineWidth; set => _LineWidth = value; }
        abstract public double Area();
        abstract public double Perimeter();



        abstract public void Draw(Graphics graphics);

    }
}
