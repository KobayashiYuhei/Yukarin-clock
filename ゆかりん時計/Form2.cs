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
    public partial class Form2 : Form
    {
        //このフォームはアラームセット時に使用されるウィンドウです。

        Form1 f1;

        public Form2(Form1 f)
        {
            this.TopMost = true;
            f1 = f;
            InitializeComponent();


        }



        private void button2_Click(object sender, EventArgs e)
        {
            //キャンセルボタンが押された時
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //セットボタンが押された時

            f1.SetTimeH = (int)numericUpDown1.Value;
            f1.SetTimeM = (int)numericUpDown2.Value;

            Label f1_label1 = (Label)f1.Controls["label1"];

            f1_label1.Text = $"Set {f1.SetTimeH,0:00}:{f1.SetTimeM,0:00}";

            // TimerSP→true
            f1.TimerSP = 1;

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //停止ボタンが押された時

            // TimeSP→false
            f1.TimerSP = 0;

            Label f1_label1 = (Label)f1.Controls["label1"];
            f1_label1.Text = "Set --:--";
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


    }
}

