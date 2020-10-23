using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            Player.URL = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
