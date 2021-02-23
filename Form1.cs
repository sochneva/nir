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
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
