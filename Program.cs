using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_5_Triangle
{
    class Triangle
    {
        private double _sideAC;

        private double _sideCB;

        private double _sideAB;
        public double SideAC
        {
            get { return _sideAC; }
            set { _sideAC = value; }
        }
        public double SideCB
        {
            get { return _sideCB; }
            set { _sideCB = value; }
        }
        public double SideAB
        {
            get { return _sideAB; }
            set { _sideAB = value; }
        }

        public double GetAngleA()
        {
            return RadianToDegree(Math.Acos((_sideAC * _sideAC + _sideAB * _sideAB - _sideCB * _sideCB)/
                (2 * _sideAC * _sideAB)));
        }
       public double GetAngleC()
        {
            return RadianToDegree(Math.Acos((_sideAC * _sideAC + _sideCB * _sideCB - _sideAB * _sideAB)/
                (2 * _sideAC * _sideCB)));
        }

        public double GetAngleB()
        {
            return 180 - (GetAngleA() + GetAngleC());
        }

        public double RadianToDegree(double radian)
        {
            return (radian * 180) / Math.PI;
        }
 
        public virtual double GetPerimeter()
        {
            return _sideAC + _sideCB + _sideAB;
        }
        static public bool ValidateSides(double sideAC, double sideCB, double sideAB)
        {
            bool valFlag = true;
            if (((sideAC + sideCB) <= sideAB) || (sideAB <= 0))
                valFlag = false;
            if (((sideAC + sideAB) <= sideCB) || (sideCB <= 0))
                valFlag = false;
            if (((sideCB + sideAB) <= sideAC) || (sideAC <= 0))
                valFlag = false;

            return valFlag;
        }
    }

    class EquilateralTriangle : Triangle
    {
        private double _area;

        public double Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public double GetArea()
        {
            return (SideAC * SideAC * Math.Sqrt(3)) / 4;
        }

        public override double GetPerimeter()
        {
            return 3 * SideAC;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
