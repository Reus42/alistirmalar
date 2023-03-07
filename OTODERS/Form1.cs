using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace OTODERS

{
    public partial class Form1 : Form
    {
        DateTime tarih = DateTime.Now;
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public Form1()
        {

            InitializeComponent();
        }
        public void DoMouseClick()
        {
            for (int i = 0; i < 2; i++)
            {
                System.Threading.Thread.Sleep(100);
                //Call the imported function with the cursor's current position
                int X = Cursor.Position.X;
                int Y = Cursor.Position.Y;
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0:dddd}", tarih);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0:dddd}", tarih);
            label2.Text = DateTime.Now.ToShortTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (label1.Text)
            {
                case "Pazartesi":
                    {
                        switch (label2.Text)
                        {
                            case "13:29":
                                System.Diagnostics.Process.Start("cmd", "/c start https://lms.ktun.edu.tr/mod/url/view.php?id=199472");
                                timer4.Start();
                                break;
                            case "15:29":
                                System.Diagnostics.Process.Start("cmd", "/c start https://lms.ktun.edu.tr/mod/url/view.php?id=198964");
                                timer4.Start();
                                break;
                        }
                        break;
                    }
                case "Salý":
                    {
                        switch (label2.Text)
                        {
                            case "10:29":

                                System.Diagnostics.Process.Start("cmd", "/c start  https://lms.ktun.edu.tr/mod/url/view.php?id=199112");
                                timer4.Start();
                                break;
                            case "14:29":
                                System.Diagnostics.Process.Start("cmd", "/c start  https://lms.ktun.edu.tr/mod/url/view.php?id=200514");
                                timer4.Start();
                                break;
                            case "15:29":
                                System.Diagnostics.Process.Start("cmd", "/c start  https://lms.ktun.edu.tr/mod/url/view.php?id=198964");
                                timer4.Start();
                                break;
                        }
                        break;
                    }
                case "Çarþamba":
                    {
                        switch (label2.Text)
                        {
                            case "10:29":
                                System.Diagnostics.Process.Start("cmd", "/c start https://lms.ktun.edu.tr/mod/url/view.php?id=199071");
                                timer4.Start();
                                break;
                            case "12:59":
                                System.Diagnostics.Process.Start("cmd", "/c start https://teams.microsoft.com/l/meetup-join/19%3ameeting_ZWNkNmIzYjQtOGQ4Ni00OTczLTlhNmMtYmZlM2QyYzJlNjIx%40thread.v2/0?context=%7b%22Tid%22%3a%22af9a1a40-e030-4a92-a04f-902360660ce0%22%2c%22Oid%22%3a%22bf331985-4413-4ec0-b957-b08e2815181a%22%7d");
                                timer4.Start();
                                break;
                            case "14:59":
                                System.Diagnostics.Process.Start("cmd", "/c start https://lms.ktun.edu.tr/mod/url/view.php?id=202249");
                                timer4.Start();
                                break;
                        }
                        break;
                    }
                case "Perþembe":
                    {
                        switch (label2.Text)
                        {
                            case "10:59":
                                System.Diagnostics.Process.Start("cmd", "/c start https://lms.ktun.edu.tr/mod/url/view.php?id=200220");
                                timer4.Start();
                                break;
                            case "13:59":
                                System.Diagnostics.Process.Start("cmd", "/c start https://teams.microsoft.com/l/meetup-join/19%3ameeting_ZWNkNmIzYjQtOGQ4Ni00OTczLTlhNmMtYmZlM2QyYzJlNjIx%40thread.v2/0?context=%7b%22Tid%22%3a%22af9a1a40-e030-4a92-a04f-902360660ce0%22%2c%22Oid%22%3a%22bf331985-4413-4ec0-b957-b08e2815181a%22%7d");
                                timer4.Start();
                                break;
                            case "14:59":
                                System.Diagnostics.Process.Start("cmd", "/c start https://lms.ktun.edu.tr/mod/url/view.php?id=198965");
                                timer4.Start();
                                break;
                        }
                        break;
                    }
                case "Cuma":
                    {
                        switch (label2.Text)
                        {
                            case "12:59":
                                System.Diagnostics.Process.Start("cmd", "/c start https://lms.ktun.edu.tr/mod/url/view.php?id=199071");
                                timer4.Start();
                                break;

                        }
                        break;
                    }
            }






        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Win32.POINT p = new Win32.POINT();
            p.x = 1380;
            p.y = 680;

            Win32.ClientToScreen(IntPtr.Zero, ref p);
            Win32.SetCursorPos(p.x, p.y);
            // Ýlk satýrda fareye sol tuþun basýlmasýný saðladýk.
            DoMouseClick();
            timer4.Stop();


        }


    }
}