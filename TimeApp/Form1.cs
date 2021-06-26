using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TimeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SoundPlayer NSound = new SoundPlayer(Properties.Resources._1);
            NSound.Play();
            MessageBox.Show("是时候休息了！是时候休息了！是时候休息了！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开启成功！");
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("关闭成功！");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            string dttext = dt.ToString("G");
            label1.Text = dttext;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
