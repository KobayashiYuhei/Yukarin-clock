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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //時報に関する関数をここで宣言
        int h;
        //時報に関する関数を秒ごとに更新させる
        int checkTime;

        public int SetTimeH;
        public int SetTimeM;
        public int TimerSP;


        private void Form1_Load(object sender, EventArgs e)
        {
            System.IO.Stream strm = Properties.Resources.Yukari;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(strm);

            player.Play();

            //時報判定用（後同期の方）
            DateTime dt = DateTime.Now;
            checkTime = dt.Hour;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToLongTimeString();
            lblTime.Text = $"{time.Hour,0:00}:{time.Minute,0:00}:{time.Second,0:00}";

            tf();
            Timer();
        }

        private void tf()
        {

            //時報判定用時刻（Hourのみ）を取得

            //必要な関数を宣言
            DateTime dt = DateTime.Now;

            //int型のh変数へ時刻（Hourのみを挿入）
            h = dt.Hour;


            if (h != checkTime)
            {

                //時報時にエラーが起きたら下記のコードを有効化
                //timer1の一時停止
                timer1.Enabled = false;

                switch (h)
                {

                    case 1:
                        //1時のときのボイスを指定
                        System.IO.Stream strm1 = Properties.Resources._1;
                        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(strm1);

                        player1.Play();

                        break;

                    case 2:
                        //2時のときのボイスを指定
                        System.IO.Stream strm2 = Properties.Resources._2;
                        System.Media.SoundPlayer player2 = new SoundPlayer(strm2);

                        player2.Play();

                        break;

                    case 3:
                        //3時のときのボイスを指定
                        System.IO.Stream strm3 = Properties.Resources._3;
                        System.Media.SoundPlayer player3 = new SoundPlayer(strm3);
                        player3.Play();

                        break;

                    case 4:
                        //4時のときのボイスを指定
                        System.IO.Stream strm4 = Properties.Resources._4;
                        System.Media.SoundPlayer player4 = new SoundPlayer(strm4);
                        player4.Play();

                        break;


                    case 5:
                        //5時のときのボイスを指定
                        System.IO.Stream strm5 = Properties.Resources._5;
                        System.Media.SoundPlayer player5 = new SoundPlayer(strm5);
                        player5.Play();

                        break;

                    case 6:
                        //6時のときのボイスを指定
                        System.IO.Stream strm6 = Properties.Resources._6;
                        System.Media.SoundPlayer player6 = new SoundPlayer(strm6);
                        player6.Play();

                        break;

                    case 7:
                        //7時のときのボイスを指定
                        System.IO.Stream strm7 = Properties.Resources._7;
                        System.Media.SoundPlayer player7 = new SoundPlayer(strm7);
                        player7.Play();

                        break;

                    case 8:
                        //8時のときのボイスを指定
                        System.IO.Stream strm8 = Properties.Resources._8;
                        System.Media.SoundPlayer player8 = new SoundPlayer(strm8);
                        player8.Play();

                        break;

                    case 9:
                        //9時のときのボイスを指定
                        System.IO.Stream strm9 = Properties.Resources._9;
                        System.Media.SoundPlayer player9 = new SoundPlayer(strm9);
                        player9.Play();

                        break;

                    case 10:
                        //10時のときのボイスを指定
                        System.IO.Stream strm10 = Properties.Resources._10;
                        System.Media.SoundPlayer player10 = new SoundPlayer(strm10);
                        player10.Play();

                        break;

                    case 11:
                        //11時のときのボイスを指定
                        System.IO.Stream strm11 = Properties.Resources._11;
                        System.Media.SoundPlayer player11 = new SoundPlayer(strm11);
                        player11.Play();

                        break;

                    case 12:
                        //12時のときのボイスを指定
                        System.IO.Stream strm12 = Properties.Resources._12;
                        System.Media.SoundPlayer player12 = new SoundPlayer(strm12);
                        player12.Play();

                        break;

                    case 13:
                        //13時のときのボイスを指定
                        System.IO.Stream strm13 = Properties.Resources._13;
                        System.Media.SoundPlayer player13 = new SoundPlayer(strm13);
                        player13.Play();

                        break;

                    case 14:
                        //14時のときのボイスを指定
                        System.IO.Stream strm14 = Properties.Resources._14;
                        System.Media.SoundPlayer player14 = new SoundPlayer(strm14);
                        player14.Play();

                        break;

                    case 15:
                        //15時のときのボイスを指定
                        System.IO.Stream strm15 = Properties.Resources._15;
                        System.Media.SoundPlayer player15 = new SoundPlayer(strm15);
                        player15.Play();


                        break;

                    case 16:
                        //16時のときのボイスを指定
                        System.IO.Stream strm16 = Properties.Resources._16;
                        System.Media.SoundPlayer player16 = new SoundPlayer(strm16);
                        player16.Play();


                        break;

                    case 17:
                        //17時のときのボイスを指定
                        System.IO.Stream strm17 = Properties.Resources._17;
                        System.Media.SoundPlayer player17 = new SoundPlayer(strm17);
                        player17.Play();

                        break;

                    case 18:
                        //18時のときのボイスを指定
                        System.IO.Stream strm18 = Properties.Resources._18;
                        System.Media.SoundPlayer player18 = new SoundPlayer(strm18);
                        player18.Play();


                        break;

                    case 19:
                        //19時のときのボイスを指定
                        System.IO.Stream strm19 = Properties.Resources._19;
                        System.Media.SoundPlayer player19 = new SoundPlayer(strm19);
                        player19.Play();


                        break;

                    case 20:
                        //20時のときのボイスを指定
                        System.IO.Stream strm20 = Properties.Resources._20;
                        System.Media.SoundPlayer player20 = new SoundPlayer(strm20);
                        player20.Play();


                        break;

                    case 21:
                        //21時のときのボイスを指定
                        System.IO.Stream strm21 = Properties.Resources._21;
                        System.Media.SoundPlayer player21 = new SoundPlayer(strm21);
                        player21.Play();


                        break;

                    case 22:
                        //22時のときのボイスを指定
                        System.IO.Stream strm22 = Properties.Resources._22;
                        System.Media.SoundPlayer player22 = new SoundPlayer(strm22);
                        player22.Play();

                        break;

                    case 23:
                        //23時のときのボイスを指定
                        System.IO.Stream strm23 = Properties.Resources._23;
                        System.Media.SoundPlayer player23 = new SoundPlayer(strm23);
                        player23.Play();

                        break;

                    case 0:
                        //24時のときのボイスを指定
                        System.IO.Stream strm24 = Properties.Resources._0;
                        System.Media.SoundPlayer player24 = new SoundPlayer(strm24);
                        player24.Play();

                        break;
                        //お疲れ様でした(；´∀｀)

                }//switchの終わり

                //ifでfalseだった場合、switch処理後にhを同期
                checkTime = h;
                //再開用
                timer1.Enabled = true;

            }//ifの終わり

        }//tfの終わり


        private void Timer()
        {
            //タイマーの通知判定処理

            DateTime dt = DateTime.Now;
            int a = dt.Minute;

            if (TimerSP == 1 && SetTimeH == checkTime && SetTimeM == a)
            {

                //timer1.Enabled = false;

                //分の一番最初だけ通知するので変数を一度2へ変更
                TimerSP = 2;
                Form3 f3 = new Form3();
                f3.ShowDialog();
                f3.Dispose();

                //timer1.Enabled = true;


            }
            else if (TimerSP == 2 && SetTimeM != a)
            {
                //タイマー起動後、繰り返さないようにする処理
                //分が移行したらもとに戻す
                TimerSP = 1;

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
            f2.Dispose();
        }

        private void 最前面へ表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            //チェック状態を反転させる
            item.Checked = !item.Checked;
            //クリックするごとにこのフォームを常に手前または解除します。
            this.TopMost = !this.TopMost;
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
