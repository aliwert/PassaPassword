﻿using System;
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                switch (ques)
                {
                    case 1:
                        if(textBox1.Text == "1.dünya savaşı")
                        {
                            button1.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button1.BackColor= Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 2:
                        if(textBox1.Text == "dönüşüm")
                        {
                            button2.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "lizozom")
                        {
                            button3.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "monolog")
                        {
                            button4.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "piri reis")
                        {
                            button5.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "Japonya Hiroşima Nagasaki")
                        {
                            button6.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "452")
                        {
                            button7.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                     
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "Cat Stevens")
                        {
                            button8.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "Şam")
                        {
                            button9.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "monolog")
                        {
                            button10.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "Etnografya müzesinde")
                        {
                            button11.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "Ağrı Dağı")
                        {
                            button12.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "Nil Nehri")
                        {
                            button13.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "Mars")
                        {
                            button14.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();

                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "Gabriel García Márquez")
                        {
                            button15.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "Ukrayna")
                        {
                            button16.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "İstanbul")
                        {
                            button17.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "Armstrong")
                        {
                            button18.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "Maraton")
                        {
                            button19.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "Uruguay")
                        {
                            button20.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "Antalya")
                        {
                            button21.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "Sakarya Meydan Muharebesi" | textBox1.Text == "Başkomutanlık Meydan Muharebesi")
                        {
                            button22.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "Jüpiter")
                        {
                            button23.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "Auguste Rodin")
                        {
                            button24.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            wrong++;
                            label4.Text = correct.ToString();
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Next Question";
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
                richTextBox1.Text = "Futbol maçlarında oynanan topun FİFA kurallarına göre ağırlığı kaç gram olmalıdır?";
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
                richTextBox1.Text = "Bilim adamlarının “Kızıl Gezegen” olarak değerlendirdiği gezegen hangisidir?";
                button14.BackColor = Color.GreenYellow;

            }
            if (ques == 15)
            {
                richTextBox1.Text = "Yüzyıllık Yalnızlık romanıyla tanınan ve 2014 yılı Nisan ayında hayatını kaybeden, Nobel ödüllü edebiyatçı kimdir?";
                button15.BackColor = Color.GreenYellow;

            }
            if (ques == 16)
            {
                richTextBox1.Text = "986 yılında nükleer bir kazanın gerçekleştiği Çernobil, günümüzde hangi ülkenin sınırları içerisinde yer almaktadır?";
                button16.BackColor = Color.GreenYellow;

            }
            if (ques == 17)
            {
                richTextBox1.Text = "Atatürk, Geldikleri gibi giderler sözünü nerede söylemiştir?";
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
            if (ques == 21)
            {
                richTextBox1.Text = "Termessos Antik Kenti hangi şehirde yer alır?";
                button21.BackColor = Color.GreenYellow;

            }
            if (ques == 22)
            {
                richTextBox1.Text = "Mustafa Kemal Atatürk'e hangi savastan sonra gazilik ve maresallik unvani verilmistir? ";
                button22.BackColor = Color.GreenYellow;

            }
            if (ques == 23)
            {
                richTextBox1.Text = "Güneş sisteminin en büyük gezegeni hangisidir?";
                button23.BackColor = Color.GreenYellow;

            }
            if (ques == 24)
            {
                richTextBox1.Text = "Düşünen Adam heykeli hangi sanatçının eseridir?";
                button24.BackColor = Color.GreenYellow;

            }

        }
    }
}
