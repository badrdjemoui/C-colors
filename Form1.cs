using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(trackBar4.Value, trackBar1.Value, trackBar2.Value, trackBar3.Value);
            textBox1.Text = panel1.BackColor.ToString();
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(trackBar4.Value, trackBar1.Value, trackBar2.Value, trackBar3.Value);
            textBox1.Text = panel1.BackColor.ToString();
        }
     

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(trackBar4.Value, trackBar1.Value, trackBar2.Value, trackBar3.Value);
            textBox1.Text = panel1.BackColor.ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(trackBar4.Value, trackBar1.Value, trackBar2.Value, trackBar3.Value);
         
            textBox1.Text = panel1.BackColor.ToString();

        }

     
    }
}
