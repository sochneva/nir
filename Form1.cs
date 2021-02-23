using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }

    struct inParam
    {
        public double t;
        public double Ngtu;
        public double Tnv;
        public double dPin;
        public double dPout;
    }

    public class GTU
    {
        private double N = 155.3;   //Электрическая мощность ГТУ брутто
        private double Nu = 98.54;  //Электрический КПД брутто
        private double G = 509.0;   //Расход выхлопных газов
        private double T = 537.0;   //Температура выхлопных газов
        private double B;   //Расход природного газа
        private double Q;   //Низшая теплота сгорания топлива

        public double calcN(double t, double Ngtu, double Tnv, double dPin, double dPout)
        {

            return 1.0;
        }
    }
}
