using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmi
{
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void BMI_DataRecived(double _coff)
        {
            trackBar1.Value = Convert.ToInt32(_coff * 10);
            label1.Text = _coff.ToString("0.0");

            double percent = ((double)trackBar1.Value + 0.0) / ((double)trackBar1.Maximum + 10.0);
            label1.Left = Convert.ToInt32(trackBar1.Width * percent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Rost = Int32.Parse(textBox1.Text);
            int Ves= Convert.ToInt32(textBox1.Text);
            float BMI;
            BMI = (Ves / (Rost * Rost));
        }
    }
}
