using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shape
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();//创建Graphics对象 
            Circle ellipse = new Circle();
            //Ellipse ellipse = new Ellipse();
            ellipse.Name = "Ellipse";
            ellipse.Position = new Point { X = 50, Y = 50 };
            ellipse.Color = Color.Red;
            ellipse.LineWidth = 1;
            //ellipse.SemiMajorAxis = 40;
            //ellipse.SemiMinorAxis = 50;
            ellipse.Radiu = 100;
            ellipse.Draw(graphics);
            Area_Label.Text = ellipse.Area().ToString();
            Perimeter_label.Text = ellipse.Perimeter().ToString();
        }


    }
}
