using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ゆかりん時計
{
    public partial class Form4 : Form
    {
        Form1 f1;

        public Form4(Form1 f)
        {
            this.TopMost = true;
            f1 = f;

            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //セットボタンが押された時

            f1.CallCHK = true;
            f1.CallH = (int)numericUpDown1.Value;
            f1.CallM = (int)numericUpDown2.Value;
            f1.CallS = (int)numericUpDown3.Value;

            if (f1.CallH == 0 && f1.CallM == 0 && f1.CallS == 0)
            {
                f1.CallCHK = false;
                Label f1_label2 = (Label)f1.Controls["label2"];
                f1_label2.Text = "Set --:--:--";
                this.Close();
            }
            else
            {
                Label f1_label2 = (Label)f1.Controls["label2"];

                f1_label2.Text = $"Set {f1.CallH,0:00}:{f1.CallM,0:00}:{f1.CallS,0:00}";

                Console.WriteLine(f1.CallH + ":" + f1.CallM + ":" + f1.CallS);

                this.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //キャンセルボタンが押された時
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            f1.CallCHK = false;
            Label f1_label2 = (Label)f1.Controls["label2"];
            f1_label2.Text = "Set --:--:--";
            this.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
