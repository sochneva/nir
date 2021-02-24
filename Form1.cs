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
        GTUModel gtuModel = new GTUModel();
        public Form1()
        {
            InitializeComponent();

            string filename = AppDomain.CurrentDomain.BaseDirectory + @"DataFiles\p-Gr.txt";
            double[,] a = FileManager.ReadFromFile(filename);  
        }

        private void trackBarChange(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            gtuModel.updateParam(trackBar.Name, trackBar.Value);
            NTextBox.Text = gtuModel.N.ToString();
            NuTextBox.Text = gtuModel.Nu.ToString();
            GTextBox.Text = gtuModel.G.ToString();
            ToutTextBox.Text = gtuModel.T.ToString();
            BTextBox.Text = gtuModel.B.ToString();
            //textBox1.Text = "";
            //textBox2.Text = "";
            //textBox3.Text = "";
            //textBox4.Text = "";
            //textBox5.Text = "";
        }

    }
}
