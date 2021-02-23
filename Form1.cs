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
            string filename = AppDomain.CurrentDomain.BaseDirectory + @"DataFiles\p-Gr.txt";
            double[,] a = FileManager.ReadFromFile(filename);
            trackBar5.Minimum = 0;
            trackBar5.Maximum = 100;
            trackBar5.TickFrequency = 10;
            dPinMin.Text = a[0,0].ToString();
            dPinMax.Text = a[0, a.GetLength(1) - 1].ToString();
            dPinCur.Text = a[0, 0].ToString();            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            string filename = AppDomain.CurrentDomain.BaseDirectory + @"DataFiles\p-Gr.txt";
            double[,] a = FileManager.ReadFromFile(filename);
            dPinCur.Text = (a[0,0] + trackBar5.Value * (a[0, a.GetLength(1) - 1] - a[0, 0]) / trackBar5.Maximum).ToString();
        }
    }
}
