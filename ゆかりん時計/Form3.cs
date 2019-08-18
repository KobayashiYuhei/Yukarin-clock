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

namespace ゆかりん時計
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();

            this.TopMost = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            System.IO.Stream strm = Properties.Resources.YukarinAram;
            System.Media.SoundPlayer player = new SoundPlayer(strm);
            player.Play();

            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            System.IO.Stream strm = Properties.Resources.YukarinAram;
            System.Media.SoundPlayer player = new SoundPlayer(strm);
            player.Play();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
    }
}

