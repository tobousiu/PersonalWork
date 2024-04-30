using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSForm_river
{
    public partial class Form : System.Windows.Forms.Form
    {
        bool SB1 = false, SB2 = false, SB3 = false, SB4 = false, SB5 = false, SB6 = false, playYN=false;
        bool Cab = false,wolf=false,sheep=false;
        bool swh = false;



        private void S4_Click(object sender, EventArgs e)
        {
            if (swh)
            {
                SB4 = !SB4;
                SB1 = false;
                SB2 = false;
                SB3 = false;
                SB5 = false;
                SB6 = false;
                if (SB4 && Cab && playYN)
                {
                    target.ForeColor = Color.DarkGreen;
                    target.BackColor = Color.LightGreen;
                    target.Text = "捲心菜";
                }
                else
                {
                    target.ForeColor = Color.Silver;
                    target.BackColor = Color.LightYellow;
                    target.Text = "無";
                }
            }
        }


        private void Boat_Click(object sender, EventArgs e)
        {
            if(swh)
            {
                playYN = !playYN;
                if (playYN)
                {
                    p2.BackColor = Color.Yellow;
                    p2.Text = "獵人";
                    p1.BackColor = Color.White;
                    p1.Text = "";
                }
                else
                {
                    p2.BackColor = Color.White;
                    p2.Text = "";
                    p1.BackColor = Color.Yellow;
                    p1.Text = "獵人";
                }

                if(target.Text=="捲心菜")
                {
                    Cab = !Cab;
                    if(SB1)
                    {
                        S4.BackColor = Color.LightGreen;
                        S4.Text = "捲心菜";
                        S1.BackColor = Color.White;
                        S1.Text = "";
                        SB1 = !SB1;
                    }
                    else
                    {
                        S1.BackColor = Color.LightGreen;
                        S1.Text = "捲心菜";
                        S4.BackColor = Color.White;
                        S4.Text = "";
                        SB4 = !SB4;
                    }
                    target.BackColor = Color.LightYellow;
                    target.ForeColor = Color.Silver;
                    target.Text = "無";
                }

                if (target.Text == "狼")
                {
                    wolf = !wolf;
                    if (SB2)
                    {
                        S5.BackColor = Color.LightGray;
                        S5.Text = "狼";
                        S2.BackColor = Color.White;
                        S2.Text = "";
                        SB2 = !SB2;
                    }
                    else
                    {
                        S2.BackColor = Color.LightGray;
                        S2.Text = "狼";
                        S5.BackColor = Color.White;
                        S5.Text = "";
                        SB5 = !SB5;
                    }
                    target.BackColor = Color.LightYellow;
                    target.ForeColor = Color.Silver;
                    target.Text = "無";
                }

                if (target.Text == "羊")
                {
                    sheep = !sheep;
                    if (SB3)
                    {
                        S6.BackColor = Color.Snow;
                        S6.Text = "羊";
                        S3.BackColor = Color.White;
                        S3.Text = "";
                        SB2 = !SB2;
                    }
                    else
                    {
                        S3.BackColor = Color.Snow;
                        S3.Text = "羊";
                        S6.BackColor = Color.White;
                        S6.Text = "";
                        SB5 = !SB5;
                    }
                    target.BackColor = Color.LightYellow;
                    target.ForeColor = Color.Silver;
                    target.Text = "無";
                }
            }
        }

        private void S2_Click(object sender, EventArgs e)
        {
            if (swh)
            {
                SB2 = !SB2;
                SB1 = false;
                SB3 = false;
                SB4 = false;
                SB5 = false;
                SB6 = false;
                if (SB2 && wolf == false && playYN == false)
                {
                    target.ForeColor = Color.Black;
                    target.BackColor = Color.LightGray;
                    target.Text = "狼";
                }
                else
                {
                    target.ForeColor = Color.Silver;
                    target.BackColor = Color.LightYellow;
                    target.Text = "無";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (swh)
            {
                if (Cab && wolf && sheep && playYN)
                {
                    swh = false;
                    game.BackColor = Color.LightGreen;
                    game.ForeColor = Color.Red;
                    game.Text = "遊戲開始";
                    SB1 = false;
                    SB2 = false;
                    SB3 = false;
                    SB4 = false;
                    SB5 = false;
                    SB6 = false;
                    Cab = false;
                    wolf = false;
                    sheep = false;
                    playYN = false;
                    timer1.Enabled = false;
                    MessageBox.Show("您贏了!!!", "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

                if ((Cab && sheep && playYN == false) || (Cab == false && sheep == false && playYN) || (wolf && sheep && playYN == false) || (wolf == false && sheep == false && playYN))
                {
                    swh = false;
                    game.BackColor = Color.LightGreen;
                    game.ForeColor = Color.Red;
                    game.Text = "遊戲開始";
                    SB1 = false;
                    SB2 = false;
                    SB3 = false;
                    SB4 = false;
                    SB5 = false;
                    SB6 = false;
                    Cab = false;
                    wolf = false;
                    sheep = false;
                    playYN = false;
                    timer1.Enabled = false;
                    MessageBox.Show("您輸了，請再接再厲!", "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void S5_Click(object sender, EventArgs e)
        {
            if (swh)
            {
                SB5 = !SB5;
                SB1 = false;
                SB2 = false;
                SB3 = false;
                SB4 = false;
                SB6 = false;
                if (SB5 && wolf && playYN)
                {
                    target.ForeColor = Color.Black;
                    target.BackColor = Color.LightGray;
                    target.Text = "狼";
                }
                else
                {
                    target.ForeColor = Color.Silver;
                    target.BackColor = Color.LightYellow;
                    target.Text = "無";
                }
            }
        }

        private void S6_Click(object sender, EventArgs e)
        {
            if (swh)
            {
                SB6 = !SB6;
                SB1 = false;
                SB2 = false;
                SB3 = false;
                SB4 = false;
                SB5 = false;
                if (SB6 && sheep && playYN)
                {
                    target.ForeColor = Color.Chocolate;
                    target.BackColor = Color.Snow;
                    target.Text = "羊";
                }
                else
                {
                    target.ForeColor = Color.Silver;
                    target.BackColor = Color.LightYellow;
                    target.Text = "無";
                }
            }
        }

        private void S3_Click(object sender, EventArgs e)
        {
            if (swh)
            {
                SB3 = !SB3;
                SB1 = false;
                SB2 = false;
                SB4 = false;
                SB5 = false;
                SB6 = false;
                if (SB3 && sheep == false && playYN == false)
                {
                    target.ForeColor = Color.Chocolate;
                    target.BackColor = Color.Snow;
                    target.Text = "羊";
                }
                else
                {
                    target.ForeColor = Color.Silver;
                    target.BackColor = Color.LightYellow;
                    target.Text = "無";
                }
            }
        }

        private void S1_Click(object sender, EventArgs e)
        {
            if(swh)
            {
                SB1 = !SB1;
                SB2 = false;
                SB3 = false;
                SB4 = false;
                SB5 = false;
                SB6 = false;
                if (SB1 && Cab == false && playYN == false)
                {
                    target.ForeColor = Color.DarkGreen;
                    target.BackColor = Color.LightGreen;
                    target.Text = "捲心菜";
                }
                else
                {
                    target.ForeColor = Color.Silver;
                    target.BackColor = Color.LightYellow;
                    target.Text = "無";
                }
            }
        }

        public Form()
        {
            InitializeComponent();
            S1.BackColor = Color.White;
            S2.BackColor = Color.White;
            S3.BackColor = Color.White;
            S4.BackColor = Color.White;
            S5.BackColor = Color.White;
            S6.BackColor = Color.White;
            p1.BackColor = Color.White;
            p2.BackColor = Color.White;
            target.BackColor = Color.White;
            S1.Text = "";
            S2.Text = "";
            S3.Text = "";
            S4.Text = "";
            S5.Text = "";
            S6.Text = "";
            p1.Text = "";
            p2.Text = "";
            target.Text = "";
        }

        private void game_Click(object sender, EventArgs e)
        {
            swh = !swh;
            if(swh)
            {
                if (MessageBox.Show("準備好開始遊戲?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    timer1.Enabled = true;
                    game.BackColor = Color.Red;
                    game.ForeColor = Color.DarkGreen;
                    game.Text = "取消";
                    S1.BackColor = Color.LightGreen;
                    S2.BackColor = Color.LightGray;
                    S3.BackColor = Color.Snow;
                    S4.BackColor = Color.White;
                    S5.BackColor = Color.White;
                    S6.BackColor = Color.White;
                    p1.BackColor = Color.Yellow;
                    p2.BackColor = Color.White;
                    target.BackColor = Color.LightYellow;
                    S1.Text = "捲心菜";
                    S2.Text = "狼";
                    S3.Text = "羊";
                    S4.Text = "";
                    S5.Text = "";
                    S6.Text = "";
                    p1.Text = "獵人";
                    p2.Text = "";
                    target.Text = "無";
                }
            }
            else
            {
                if (MessageBox.Show("確定要取消遊戲?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    game.BackColor = Color.LightGreen;
                    game.ForeColor = Color.Red;
                    game.Text = "遊戲開始";
                    S1.BackColor = Color.White;
                    S2.BackColor = Color.White;
                    S3.BackColor = Color.White;
                    S4.BackColor = Color.White;
                    S5.BackColor = Color.White;
                    S6.BackColor = Color.White;
                    p1.BackColor = Color.White;
                    p2.BackColor = Color.White;
                    target.BackColor = Color.White;
                    S1.Text = "";
                    S2.Text = "";
                    S3.Text = "";
                    S4.Text = "";
                    S5.Text = "";
                    S6.Text = "";
                    p1.Text = "";
                    p2.Text = "";
                    target.Text = "";
                    SB1 = false;
                    SB2 = false;
                    SB3 = false;
                    SB4 = false;
                    SB5 = false;
                    SB6 = false;
                    Cab = false;
                    wolf = false;
                    sheep = false;
                }
            }
        }

        private void rule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("歡迎來到渡河遊戲,規則如下:\r\n" +
                "1.如果所有羊、狼、捲心菜以及獵人都在對岸，遊戲勝利並結束!\r\n"+
                "2.選擇完對象按船即可讓該對象以及獵人本身渡河到對岸，當然也可以只有獵人單獨過河。\r\n" +
                "3.按下對象(例如捲心菜、羊等)上方訊息框會出現該選擇對象，在按一次就會取消對象並且上方訊息框顯示無(表示按船只有獵人渡河)，也可以按其他對象替換。\r\n" +
                "4.如果任意岸出現羊跟捲心菜獨處、狼跟羊獨處並且獵人沒有出現在該岸，則遊戲失敗並結束!\r\n",
                "遊戲規則",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
    }
}
