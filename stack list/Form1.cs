using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace stack_list
{
    public partial class Form1 : Form
    {
        int dogru = 0;
        int a = 1;

        Stack<int> stack = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();
        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            monoFlat_Button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<int> list = new List<int> { 8, 3, 6, 1 };
            

            var random = new Random();
            timer2.Start();


            var rndsayi = random.Next(list.Count);


            monoFlat_Label2.Location = new Point(260, 341);
            monoFlat_Label2.Text = "                               " + Convert.ToString(list[rndsayi]);

            stack.Push(list[rndsayi]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (monoFlat_ThemeContainer1.Dock == DockStyle.Fill)
            {
                monoFlat_Button2.Enabled = false;
                monoFlat_Button3.Enabled = false;
                monoFlat_Button4.Enabled = false;
                monoFlat_Button5.Enabled = false;
            }
            monoFlat_ThemeContainer1.Dock = DockStyle.None;
            monoFlat_ThemeContainer2.Dock = DockStyle.Fill;
            monoFlat_ThemeContainer1.Dock = DockStyle.None;
          //  monoFlat_ThemeContainer1.Dock = DockStyle.Fill;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            monoFlat_Button2.Enabled = true;
            monoFlat_Button3.Enabled = true;
            monoFlat_Button4.Enabled = true;
            monoFlat_Button5.Enabled = true;
            for (int i = 0; i <= 3; i++)
            {

                if (stack.Count == 0)
                {
                    timer2.Stop();
                }
                else
                {

                }
            }
            timer1.Stop();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (dogru == 4)
            {
                monoFlat_Label2.Text = "TEBRİKLER YENİ BÖLÜME GEÇİLİYOR";
                monoFlat_Button2.Enabled = false;
                monoFlat_Button3.Enabled = false;
                monoFlat_Button4.Enabled = false;
                monoFlat_Button5.Enabled = false;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
            }
            if (a == -1)
            {
                monoFlat_Label2.Text = "Kaybettiniz. :/";
                monoFlat_Button2.Enabled = false;
                monoFlat_Button3.Enabled = false;
                monoFlat_Button4.Enabled = false;
                monoFlat_Button5.Enabled = false;
                monoFlat_Button1.Text = "Yeniden Dene";
                monoFlat_Button1.Enabled = true;
                timer3.Stop();
                timer1.Stop();
                timer2.Stop();
                timer3.Start();
                dogru = 0;


                timer5.Start();

                a = 1;
                monoFlat_Label3.Text = "Kalan Yanlış Tıklama Hakkınız:" + Convert.ToString(a);

            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (true)
            {
                monoFlat_Button2.Enabled = true;
                monoFlat_Button3.Enabled = true;
                monoFlat_Button4.Enabled = true;
                monoFlat_Button5.Enabled = true;
                timer4.Stop();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (monoFlat_Label2.Text == "Kaybettiniz. :/")
            {
                monoFlat_Button2.Enabled = false;
                monoFlat_Button3.Enabled = false;
                monoFlat_Button4.Enabled = false;
                monoFlat_Button5.Enabled = false;

            }
            timer5.Stop();

        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            monoFlat_Button1.Enabled = false;
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            timer4.Start();


            if (monoFlat_Button2.Text == Convert.ToString(stack.Peek()))
            {
                monoFlat_Button2.Enabled = false;

                dogru++;
                stack.Pop();
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\true.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            }
            else
            {
                a--;
                monoFlat_Label3.Text = "Kalan Yanlış Tıklama Hakkınız:" + Convert.ToString(a);
                Console.Beep(2000, 180);
                Console.Beep(2000, 300);
            }
        }

        private void monoFlat_Button3_Click(object sender, EventArgs e)
        {
            timer4.Start();

            if (monoFlat_Button3.Text == Convert.ToString(stack.Peek()))
            {
                monoFlat_Button3.Enabled = false;
                dogru++;
                stack.Pop();
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\true.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            }
            else
            {
                a--;

                monoFlat_Label3.Text = "Kalan Yanlış Tıklama Hakkınız:" + Convert.ToString(a);
                Console.Beep(2000, 180);
                Console.Beep(2000, 300);
            }
        }

        private void monoFlat_Button4_Click(object sender, EventArgs e)
        {
            timer4.Start();

            if (monoFlat_Button4.Text == Convert.ToString(stack.Peek()))
            {
                monoFlat_Button4.Enabled = false;
                dogru++;
                stack.Pop();
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\true.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            }
            else
            {
                a--;
                monoFlat_Label3.Text = "Kalan Yanlış Tıklama Hakkınız:" + Convert.ToString(a);
                Console.Beep(2000, 180);
                Console.Beep(2000, 300);
            }
        }

        private void monoFlat_Button5_Click(object sender, EventArgs e)
        {
            timer4.Start();

            if (monoFlat_Button5.Text == Convert.ToString(stack.Peek()))
            {
                monoFlat_Button5.Enabled = false;
                dogru++;
                stack.Pop();
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\true.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            }
            else
            {
                a--;
                monoFlat_Label3.Text = "Kalan Yanlış Tıklama Hakkınız:" + Convert.ToString(a);
                Console.Beep(2000, 180);
                Console.Beep(2000, 300);
            }
        }

        private void monoFlat_Label2_Click(object sender, EventArgs e)
        {

        }

        private void monoFlat_Button6_Click(object sender, EventArgs e)
        {
            monoFlat_ThemeContainer1.Dock = DockStyle.None;
            monoFlat_ThemeContainer1.Location = new Point(1000, 1000);
            monoFlat_ThemeContainer2.Dock = DockStyle.Fill;
        }

        private void monoFlat_Button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void monoFlat_Button7_Click(object sender, EventArgs e)
        {
            monoFlat_ThemeContainer2.Dock = DockStyle.None;
            monoFlat_ThemeContainer2.Location = new Point(1000, 1000);
            monoFlat_ThemeContainer1.Dock = DockStyle.Fill;
        }

        private void monoFlat_ThemeContainer2_Click(object sender, EventArgs e)
        {

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (monoFlat_Label2.Text == "TEBRİKLER YENİ BÖLÜME GEÇİLİYOR")
            {
                monoFlat_Button2.Visible = false;
                monoFlat_Button3.Visible = false;
                monoFlat_Button4.Visible = false;
                monoFlat_Button5.Visible = false;
                
                monoFlat_Button12.Visible = true;
                monoFlat_Button13.Visible = true;
                monoFlat_Button14.Visible = true;
                monoFlat_Button15.Visible = true;
                monoFlat_Button16.Visible = true;

                monoFlat_Button12.Size = new Size(865,51);
                monoFlat_Button13.Size = new Size(865, 51);
                monoFlat_Button14.Size = new Size(865, 51);
                monoFlat_Button15.Size = new Size(865, 51);
                monoFlat_Button16.Size = new Size(865, 51);

                monoFlat_Button12.Location = new Point(254, 493);
                monoFlat_Button13.Location = new Point(254, 550);
                monoFlat_Button14.Location = new Point(254, 607);
                monoFlat_Button15.Location = new Point(254, 664);
                monoFlat_Button16.Location = new Point(254, 436);
                timer11.Start();
                dogru = 0;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            monoFlat_Button12.Enabled = true;
            monoFlat_Button13.Enabled = true;
            monoFlat_Button14.Enabled = true;
            monoFlat_Button15.Enabled = true;
            monoFlat_Button16.Enabled = true;
            for (int i = 0; i <= 3; i++)
            {

                if (stack2.Count == 0)
                {
                    timer7.Stop();
                }
                else
                {

                }

            }
            timer11.Stop();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {

            if (dogru == 5)
            {
                monoFlat_Label2.Text = "TEBRİKLER OYUN BİTTİ(Yeni bölüm yakında)";
                monoFlat_Button12.Enabled = false;
                monoFlat_Button13.Enabled = false;
                monoFlat_Button14.Enabled = false;
                monoFlat_Button15.Enabled = false;
                monoFlat_Button16.Enabled = false;
                timer6.Stop();
                timer7.Stop();
                timer8.Stop();
                timer9.Stop();
                timer10.Stop();
                timer11.Stop();
            }
            if (a == -1)
            {
                monoFlat_Label2.Text = "Kaybettiniz. :/";
                monoFlat_Button12.Enabled = false;
                monoFlat_Button13.Enabled = false;
                monoFlat_Button14.Enabled = false;
                monoFlat_Button15.Enabled = false;
                monoFlat_Button16.Enabled = false;

                monoFlat_Button1.Text = "Yeniden Dene";
                monoFlat_Button1.Enabled = true;
                timer8.Stop();
                timer6.Stop();
                timer7.Stop();
                timer8.Start();
                dogru = 0;
                timer10.Start();

                a = 1;
                monoFlat_Label3.Text = "Kalan Yanlış Tıklama Hakkınız:" + Convert.ToString(a);
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            if (monoFlat_Label2.Text == "Kaybettiniz. :/")
            {
                monoFlat_Button12.Enabled = false;
                monoFlat_Button13.Enabled = false;
                monoFlat_Button14.Enabled = false;
                monoFlat_Button15.Enabled = false;
                monoFlat_Button16.Enabled = false;
            }
            timer5.Stop();

        }

        private void monoFlat_Button14_Click(object sender, EventArgs e)
        {
            timer9.Start();

            if (monoFlat_Button14.Text == Convert.ToString(stack2.Peek()))
            {
                monoFlat_Button14.Enabled = false;
                dogru++;
                stack2.Pop();
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\true.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            }
            else
            {
                a--;

                monoFlat_Label3.Text = "Kalan Yanlış Tıklama Hakkınız:" + Convert.ToString(a);
                Console.Beep(2000, 180);
                Console.Beep(2000, 300);
            }
        }

        private void monoFlat_Button13_Click(object sender, EventArgs e)
        {
            {
                timer9.Start();

                if (monoFlat_Button13.Text == Convert.ToString(stack2.Peek()))
                {
                    monoFlat_Button13.Enabled = false;
                    dogru++;
                    stack2.Pop();
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\true.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    a--;

                    monoFlat_Label3.Text = "Kalan Yanlış Tıklama Hakkınız:" + Convert.ToString(a);
                    Console.Beep(2000, 180);
                    Console.Beep(2000, 300);
                }
            }
        }

        private void monoFlat_Button15_Click(object sender, EventArgs e)
        {
            {
                timer9.Start();

                if (monoFlat_Button15.Text == Convert.ToString(stack2.Peek()))
                {
                    monoFlat_Button15.Enabled = false;
                    dogru++;
                    stack2.Pop();
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\true.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    a--;

                    monoFlat_Label3.Text = "Kalan Yanlış Tıklama Hakkınız:" + Convert.ToString(a);
                    Console.Beep(2000, 180);
                    Console.Beep(2000, 300);
                }
            }
        }

        private void monoFlat_Button12_Click(object sender, EventArgs e)
        {
            {
                timer9.Start();

                if (monoFlat_Button12.Text == Convert.ToString(stack2.Peek()))
                {
                    monoFlat_Button12.Enabled = false;
                    dogru++;
                    stack2.Pop();
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\true.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    a--;

                    monoFlat_Label3.Text = "Kalan Yanlış Tıklama Hakkınız:" + Convert.ToString(a);
                    Console.Beep(2000, 180);
                    Console.Beep(2000, 300);
                }
            }
        }

        private void monoFlat_Button16_Click(object sender, EventArgs e)
        {
            {
                timer9.Start();

                if (monoFlat_Button16.Text == Convert.ToString(stack2.Peek()))
                {
                    monoFlat_Button16.Enabled = false;
                    dogru++;
                    stack2.Pop();
                    SoundPlayer ses = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\true.wav";
                    ses.SoundLocation = dizin;
                    ses.Play();
                }
                else
                {
                    a--;

                    monoFlat_Label3.Text = "Kalan Yanlış Tıklama Hakkınız:" + Convert.ToString(a);
                    Console.Beep(2000, 180);
                    Console.Beep(2000, 300);
                }
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
           
            List<int> list2 = new List<int> { 5, 2, 7, 9, 8 };
            var random = new Random();
            timer7.Start();


            var rnd2sayi = random.Next(list2.Count);


            monoFlat_Label2.Location = new Point(260, 341);
            monoFlat_Label2.Text = "                               " + Convert.ToString(list2[rnd2sayi]);

            stack2.Push(list2[rnd2sayi]);
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (true)
            {
                monoFlat_Button2.Enabled = true;
                monoFlat_Button3.Enabled = true;
                monoFlat_Button4.Enabled = true;
                monoFlat_Button5.Enabled = true;
                timer9.Stop();
            }
        }

        private void monoFlat_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }

        private void monoFlat_Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form2 = new Form2();
            Form2.Show();
        }
    }
}
