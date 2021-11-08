using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_5_Triangle
{
    public partial class Form1 : Form
    {
        private Triangle _triangle;

        private EquilateralTriangle _equilateralTriangle;
        public Form1()
        {
            InitializeComponent();
        }
        private void NewTriangle()
        {
            if (Triangle.ValidateSides(Convert.ToDouble(TextAC.Text),
                Convert.ToDouble(TextCB.Text), Convert.ToDouble(TextAB.Text)))
            {
                _triangle = new Triangle()
                {
                    SideAC = Convert.ToDouble(TextAC.Text),
                    SideCB = Convert.ToDouble(TextCB.Text),
                    SideAB = Convert.ToDouble(TextAB.Text)
                };
            }
            else
            {
                MessageBox.Show("The sum of the lengths of the two sides" +
                    " of the triangle must be less than the length of the third side.");
            }
        }
        private void NewEquilateralTriangle()
        {
            _equilateralTriangle = new EquilateralTriangle()
            {
                SideAC = Convert.ToDouble(TextAC.Text)
            };
        }

        private void CheckEquilateral_Click(object sender, EventArgs e)
        {
            if (CheckEquilateral.Checked)
            {
                BArea.Enabled = true;
                TextAB.Enabled = false;
                TextCB.Enabled = false;
                BAngleA.Enabled = false;
                BAngleB.Enabled = false;
                BAngleC.Enabled = false;
            }
            else
            {
                BArea.Enabled = false;
                TextAB.Enabled = true;
                TextCB.Enabled = true;
                BAngleA.Enabled = true;
                BAngleB.Enabled = true;
                BAngleC.Enabled = true;
            }
        }

        private void BPerimeter_Click(object sender, EventArgs e)
        {
            if (CheckEquilateral.Checked)
            {
                NewEquilateralTriangle();
                textResult.Text = Convert.ToString(_equilateralTriangle.GetPerimeter());
            }
            else
            {
                NewTriangle();
                textResult.Text = Convert.ToString(_triangle.GetPerimeter());
            }
        }

        private void BArea_Click(object sender, EventArgs e)
        {
            NewEquilateralTriangle();
            textResult.Text = Convert.ToString(_equilateralTriangle.GetArea());
        }

        private void BAngleA_Click(object sender, EventArgs e)
        {
            NewTriangle();
            textResult.Text = Convert.ToString(_triangle.GetAngleA());
        }

        private void BAngleC_Click(object sender, EventArgs e)
        {
            NewTriangle();
            textResult.Text = Convert.ToString(_triangle.GetAngleC());
        }

        private void BAngleB_Click(object sender, EventArgs e)
        {
            NewTriangle();
            textResult.Text = Convert.ToString(_triangle.GetAngleB());
        }
    }
}
