using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ques = 0, correct = 0, wrong = 0;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Answer to question";
            ques++;
            this.Text = ques.ToString();
            if (ques == 1)
            {
                richTextBox1.Text = "Çanakkale Zaferi’nin dahil olduğu savaş hangisidir?";
                button1.BackColor = Color.GreenYellow;

            }
            if (ques == 2)
            {
                richTextBox1.Text = "Gregor Samsa karakterinin yer aldığı roman hangisidir?";
                button2.BackColor = Color.GreenYellow;

            }
            if (ques == 3)
            {
                richTextBox1.Text = "Hücre yapısında yer alan organelin adı nedir?";
                button3.BackColor = Color.GreenYellow;

            }
            if (ques == 4)
            {
                richTextBox1.Text = "Tiyatroda kendi kendine konuşma olarak bilinen türün adı nedir?";
                button4.BackColor = Color.GreenYellow;

            }
            if (ques == 5)
            {
                richTextBox1.Text = "İlk defa dünya haritasını kim çizmiştir?";
                button5.BackColor = Color.GreenYellow;

            }
            if (ques == 6)
            {
                richTextBox1.Text = "İkinci Dünya Savaşında hangi ülkeye atom bombası atılmıştır ve atılan şehirler hangileridir?";
                button6.BackColor = Color.GreenYellow;

            }
            if (ques == 7)
            {
                richTextBox1.Text = "Futbol maçlarında oynanan topun FİFA kurallarına göre ağırlığı ne kadar olmalıdır?";
                button7.BackColor = Color.GreenYellow;

            }
            if (ques == 8)
            {
                richTextBox1.Text = "Yetmişli yılların sonunda İslam’ı seçen ünlü pop sanatçısı kimdir?";
                button8.BackColor = Color.GreenYellow;

            }
            if (ques == 9)
            {
                richTextBox1.Text = "Atatürk'ün ilk görev yeri";
                button9.BackColor = Color.GreenYellow;

            }
            if (ques == 10)
            {
                richTextBox1.Text = "Ülkemizdeki mareşal unvanı alan iki kişi kimdir?";
                button10.BackColor = Color.GreenYellow;
                

            }
            if (ques == 11)
            {
                richTextBox1.Text = "Atatürk Anıtkabir'e taşınmadan önce nerede yattı?";
                button11.BackColor = Color.GreenYellow;

            }
            if (ques == 12)
            {
                richTextBox1.Text = "Türkiye’nin en yüksek dağı hangisidir?";
                button12.BackColor = Color.GreenYellow;

            }
            if (ques == 13)
            {
                richTextBox1.Text = "Dünyanın en uzun nehrinin adı nedir?";
                button13.BackColor = Color.GreenYellow;

            }
            if (ques == 14)
            {
                richTextBox1.Text = "Dünyanın en uzun nehrinin adı nedir?";
                button14.BackColor = Color.GreenYellow;

            }
            if (ques == 15)
            {
                richTextBox1.Text = "Dünyanın en uzun nehrinin adı nedir?";
                button15.BackColor = Color.GreenYellow;

            }
            if (ques == 16)
            {
                richTextBox1.Text = "Dünyanın en uzun nehrinin adı nedir?";
                button16.BackColor = Color.GreenYellow;

            }
            if (ques == 17)
            {
                richTextBox1.Text = "Dünyanın en uzun nehrinin adı nedir?";
                button17.BackColor = Color.GreenYellow;

            }
            if (ques == 18)
            {
                richTextBox1.Text = "Aya ilk defa kaç yılında ve kim ayak bastı?";
                button18.BackColor = Color.GreenYellow;

            }
            if (ques == 19)
            {
                richTextBox1.Text = "Atletizmde mesafe olarak en uzun koşuya verilen isim nedir?";
                button19.BackColor = Color.GreenYellow;

            }
            if (ques == 20)
            {
                richTextBox1.Text = "Dünya kupasını ilk kez kim kazanmıştır?";
                button20.BackColor = Color.GreenYellow;

            }

        }
    }
}
