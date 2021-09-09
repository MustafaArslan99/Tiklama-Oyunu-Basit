using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IdleGame
{
    public partial class GamePage : Form
    {
        int para;
        int artismiktar = 1;

        public GamePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            para = Convert.ToInt32(lbl_para.Text);
            para+=artismiktar;
            lbl_para.Text = para.ToString();
            Item1Kontrol();
            Item2Kontrol();
        }
        public void Item1Kontrol()
        {
            if (para<25)
            {
                btn_item1.Enabled = false;
            }
            else
            {
                btn_item1.Enabled = true;
            }
        }
        public void Item2Kontrol()
        {
            if (para<40)
            {
                btn_item2.Enabled = false;
            }
            else
            {
                btn_item2.Enabled = true;
            }
        }
        public void Tiklama1Kontrol()
        {
            if (para<50)
            {
                btn_tiklama1.Enabled = false;
            }
            else
            {
                btn_tiklama1.Enabled = true;
            }
        }
        private void GamePage_Load(object sender, EventArgs e)
        {            
            para = Convert.ToInt32(lbl_para.Text);
            Timer1.Start();            
            TimerKontrol.Start();
        }

        private void btn_item1_Click(object sender, EventArgs e)
        {
            para -= 25;
            lbl_para.Text = para.ToString();
            int pasifincome=Convert.ToInt32(lbl_saniyelikkazanc.Text);
            pasifincome++;
            lbl_saniyelikkazanc.Text = pasifincome.ToString();
            Timer1.Start();
            Item1Kontrol();
            
        }

        private void Buton1_Tick(object sender, EventArgs e)
        {
            int eklenecekpara = Convert.ToInt32(lbl_saniyelikkazanc.Text);
            para += eklenecekpara;
            lbl_para.Text = para.ToString();
            Item1Kontrol();
            Item2Kontrol();
        }

        private void btn_item2_Click(object sender, EventArgs e)
        {
            para -= 40;
            lbl_para.Text = para.ToString();
            int pasifincome = Convert.ToInt32(lbl_saniyelikkazanc.Text);
            pasifincome+=2;
            lbl_saniyelikkazanc.Text = pasifincome.ToString();
            Timer1.Start();
            Item1Kontrol();
            Item2Kontrol();
        }

        private void btn_tiklama1_Click(object sender, EventArgs e)
        {
            para -= 50;
            lbl_para.Text = para.ToString();
            artismiktar++;
            button1.Text = "+" + artismiktar;
        }

        private void TimerKontrol_Tick(object sender, EventArgs e)
        {
            Item1Kontrol();
            Item2Kontrol();
            Tiklama1Kontrol();
        }
    }
}
