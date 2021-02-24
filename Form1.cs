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
            dPinTrackBar.Minimum = 0;
            dPinTrackBar.Maximum = 100;
            dPinTrackBar.TickFrequency = 10;
            dPinMin.Text = a[0,0].ToString();
            dPinMax.Text = a[0, a.GetLength(1) - 1].ToString();
            dPinCur.Text = a[0, 0].ToString();            
        }
        private void tTrackBar_Scroll(object sender, EventArgs e)
        {

        private void trackBarChange(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            gtuModel.updateParam(trackBar.Name, trackBar.Value);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

    }
}
