
namespace stack_list
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.monoFlat_Button16 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button12 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button13 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button14 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button15 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button6 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Label3 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Button5 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button4 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button3 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button2 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_ThemeContainer2 = new MonoFlat.MonoFlat_ThemeContainer();
            this.monoFlat_Button11 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button9 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Button7 = new MonoFlat.MonoFlat_Button();
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.timer9 = new System.Windows.Forms.Timer(this.components);
            this.timer10 = new System.Windows.Forms.Timer(this.components);
            this.timer11 = new System.Windows.Forms.Timer(this.components);
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.monoFlat_ThemeContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 3200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 800;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // timer4
            // 
            this.timer4.Interval = 780;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button16);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button12);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button13);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button14);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button15);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button6);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label3);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label2);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button5);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button4);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button3);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button2);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Label1);
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(1378, 771);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(643, 287);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.monoFlat_ThemeContainer1.TabIndex = 13;
            this.monoFlat_ThemeContainer1.Text = "MAKÜ     ZEKA     OYUNLARI    SETİ    v1";
            this.monoFlat_ThemeContainer1.Click += new System.EventHandler(this.monoFlat_ThemeContainer1_Click);
            // 
            // monoFlat_Button16
            // 
            this.monoFlat_Button16.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.monoFlat_Button16.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button16.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Button16.Image = null;
            this.monoFlat_Button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button16.Location = new System.Drawing.Point(-147, -63);
            this.monoFlat_Button16.Name = "monoFlat_Button16";
            this.monoFlat_Button16.Padding = new System.Windows.Forms.Padding(30);
            this.monoFlat_Button16.Size = new System.Drawing.Size(532, 24);
            this.monoFlat_Button16.TabIndex = 19;
            this.monoFlat_Button16.Text = "9";
            this.monoFlat_Button16.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button16.Visible = false;
            this.monoFlat_Button16.Click += new System.EventHandler(this.monoFlat_Button16_Click);
            // 
            // monoFlat_Button12
            // 
            this.monoFlat_Button12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.monoFlat_Button12.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button12.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Button12.Image = null;
            this.monoFlat_Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button12.Location = new System.Drawing.Point(-147, -93);
            this.monoFlat_Button12.Name = "monoFlat_Button12";
            this.monoFlat_Button12.Padding = new System.Windows.Forms.Padding(30);
            this.monoFlat_Button12.Size = new System.Drawing.Size(532, 24);
            this.monoFlat_Button12.TabIndex = 18;
            this.monoFlat_Button12.Text = "7";
            this.monoFlat_Button12.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button12.Visible = false;
            this.monoFlat_Button12.Click += new System.EventHandler(this.monoFlat_Button12_Click);
            // 
            // monoFlat_Button13
            // 
            this.monoFlat_Button13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.monoFlat_Button13.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button13.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold);
            this.monoFlat_Button13.Image = null;
            this.monoFlat_Button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button13.Location = new System.Drawing.Point(-147, -151);
            this.monoFlat_Button13.Name = "monoFlat_Button13";
            this.monoFlat_Button13.Padding = new System.Windows.Forms.Padding(30);
            this.monoFlat_Button13.Size = new System.Drawing.Size(532, 24);
            this.monoFlat_Button13.TabIndex = 17;
            this.monoFlat_Button13.Text = "8";
            this.monoFlat_Button13.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button13.Visible = false;
            this.monoFlat_Button13.Click += new System.EventHandler(this.monoFlat_Button13_Click);
            // 
            // monoFlat_Button14
            // 
            this.monoFlat_Button14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.monoFlat_Button14.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button14.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold);
            this.monoFlat_Button14.Image = null;
            this.monoFlat_Button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button14.Location = new System.Drawing.Point(-148, -181);
            this.monoFlat_Button14.Name = "monoFlat_Button14";
            this.monoFlat_Button14.Padding = new System.Windows.Forms.Padding(30);
            this.monoFlat_Button14.Size = new System.Drawing.Size(532, 24);
            this.monoFlat_Button14.TabIndex = 16;
            this.monoFlat_Button14.Text = "2";
            this.monoFlat_Button14.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button14.Visible = false;
            this.monoFlat_Button14.Click += new System.EventHandler(this.monoFlat_Button14_Click);
            // 
            // monoFlat_Button15
            // 
            this.monoFlat_Button15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.monoFlat_Button15.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button15.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold);
            this.monoFlat_Button15.Image = null;
            this.monoFlat_Button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button15.Location = new System.Drawing.Point(-147, -123);
            this.monoFlat_Button15.Name = "monoFlat_Button15";
            this.monoFlat_Button15.Padding = new System.Windows.Forms.Padding(30);
            this.monoFlat_Button15.Size = new System.Drawing.Size(532, 24);
            this.monoFlat_Button15.TabIndex = 15;
            this.monoFlat_Button15.Text = "5";
            this.monoFlat_Button15.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button15.Visible = false;
            this.monoFlat_Button15.Click += new System.EventHandler(this.monoFlat_Button15_Click);
            // 
            // monoFlat_Button6
            // 
            this.monoFlat_Button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monoFlat_Button6.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button6.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold);
            this.monoFlat_Button6.Image = null;
            this.monoFlat_Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button6.Location = new System.Drawing.Point(13, 234);
            this.monoFlat_Button6.Name = "monoFlat_Button6";
            this.monoFlat_Button6.Size = new System.Drawing.Size(146, 41);
            this.monoFlat_Button6.TabIndex = 14;
            this.monoFlat_Button6.Text = "LOBİYE DÖN";
            this.monoFlat_Button6.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button6.Click += new System.EventHandler(this.monoFlat_Button6_Click);
            // 
            // monoFlat_Label3
            // 
            this.monoFlat_Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_Label3.AutoSize = true;
            this.monoFlat_Label3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(175)))), ((int)(((byte)(132)))));
            this.monoFlat_Label3.Location = new System.Drawing.Point(461, 263);
            this.monoFlat_Label3.Name = "monoFlat_Label3";
            this.monoFlat_Label3.Size = new System.Drawing.Size(170, 15);
            this.monoFlat_Label3.TabIndex = 13;
            this.monoFlat_Label3.Text = "Kalan Yanlış Tıklama Hakkınız:1";
            // 
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(175)))), ((int)(((byte)(132)))));
            this.monoFlat_Label2.Location = new System.Drawing.Point(493, 341);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(432, 65);
            this.monoFlat_Label2.TabIndex = 6;
            this.monoFlat_Label2.Text = "Sayılar yükleniyor";
            this.monoFlat_Label2.Click += new System.EventHandler(this.monoFlat_Label2_Click);
            // 
            // monoFlat_Button5
            // 
            this.monoFlat_Button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.monoFlat_Button5.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button5.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Button5.Image = null;
            this.monoFlat_Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button5.Location = new System.Drawing.Point(-114, 163);
            this.monoFlat_Button5.Name = "monoFlat_Button5";
            this.monoFlat_Button5.Padding = new System.Windows.Forms.Padding(30);
            this.monoFlat_Button5.Size = new System.Drawing.Size(865, 51);
            this.monoFlat_Button5.TabIndex = 5;
            this.monoFlat_Button5.Text = "6";
            this.monoFlat_Button5.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button5.Click += new System.EventHandler(this.monoFlat_Button5_Click);
            // 
            // monoFlat_Button4
            // 
            this.monoFlat_Button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.monoFlat_Button4.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button4.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold);
            this.monoFlat_Button4.Image = null;
            this.monoFlat_Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button4.Location = new System.Drawing.Point(-114, 49);
            this.monoFlat_Button4.Name = "monoFlat_Button4";
            this.monoFlat_Button4.Padding = new System.Windows.Forms.Padding(30);
            this.monoFlat_Button4.Size = new System.Drawing.Size(865, 51);
            this.monoFlat_Button4.TabIndex = 4;
            this.monoFlat_Button4.Text = "8";
            this.monoFlat_Button4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button4.Click += new System.EventHandler(this.monoFlat_Button4_Click);
            // 
            // monoFlat_Button3
            // 
            this.monoFlat_Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.monoFlat_Button3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button3.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold);
            this.monoFlat_Button3.Image = null;
            this.monoFlat_Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button3.Location = new System.Drawing.Point(-114, -8);
            this.monoFlat_Button3.Name = "monoFlat_Button3";
            this.monoFlat_Button3.Padding = new System.Windows.Forms.Padding(30);
            this.monoFlat_Button3.Size = new System.Drawing.Size(865, 51);
            this.monoFlat_Button3.TabIndex = 3;
            this.monoFlat_Button3.Text = "3";
            this.monoFlat_Button3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button3.Click += new System.EventHandler(this.monoFlat_Button3_Click);
            // 
            // monoFlat_Button2
            // 
            this.monoFlat_Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.monoFlat_Button2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button2.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold);
            this.monoFlat_Button2.Image = null;
            this.monoFlat_Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button2.Location = new System.Drawing.Point(-114, 106);
            this.monoFlat_Button2.Name = "monoFlat_Button2";
            this.monoFlat_Button2.Padding = new System.Windows.Forms.Padding(30);
            this.monoFlat_Button2.Size = new System.Drawing.Size(865, 51);
            this.monoFlat_Button2.TabIndex = 2;
            this.monoFlat_Button2.Text = "1";
            this.monoFlat_Button2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button2.Click += new System.EventHandler(this.monoFlat_Button2_Click);
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(11, 236);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(623, 78);
            this.monoFlat_Button1.TabIndex = 1;
            this.monoFlat_Button1.Text = "Hazırsanız Başlayalım";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button1.Click += new System.EventHandler(this.monoFlat_Button1_Click);
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(175)))), ((int)(((byte)(132)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(-62, 70);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(657, 125);
            this.monoFlat_Label1.TabIndex = 0;
            this.monoFlat_Label1.Text = resources.GetString("monoFlat_Label1.Text");
            // 
            // monoFlat_ThemeContainer2
            // 
            this.monoFlat_ThemeContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer2.Controls.Add(this.monoFlat_Button11);
            this.monoFlat_ThemeContainer2.Controls.Add(this.monoFlat_Button9);
            this.monoFlat_ThemeContainer2.Controls.Add(this.monoFlat_Button7);
            this.monoFlat_ThemeContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer2.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer2.Name = "monoFlat_ThemeContainer2";
            this.monoFlat_ThemeContainer2.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer2.RoundCorners = true;
            this.monoFlat_ThemeContainer2.Sizable = true;
            this.monoFlat_ThemeContainer2.Size = new System.Drawing.Size(689, 436);
            this.monoFlat_ThemeContainer2.SmartBounds = true;
            this.monoFlat_ThemeContainer2.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.monoFlat_ThemeContainer2.TabIndex = 14;
            this.monoFlat_ThemeContainer2.Text = "MAKÜ     ZEKA     OYUNLARI    SETİ    v1";
            this.monoFlat_ThemeContainer2.Click += new System.EventHandler(this.monoFlat_ThemeContainer2_Click);
            // 
            // monoFlat_Button11
            // 
            this.monoFlat_Button11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_Button11.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button11.Image = null;
            this.monoFlat_Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button11.Location = new System.Drawing.Point(13, 202);
            this.monoFlat_Button11.Name = "monoFlat_Button11";
            this.monoFlat_Button11.Size = new System.Drawing.Size(664, 51);
            this.monoFlat_Button11.TabIndex = 4;
            this.monoFlat_Button11.Text = "PROGRAMI KAPAT";
            this.monoFlat_Button11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button11.Click += new System.EventHandler(this.monoFlat_Button11_Click);
            // 
            // monoFlat_Button9
            // 
            this.monoFlat_Button9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_Button9.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button9.Image = null;
            this.monoFlat_Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button9.Location = new System.Drawing.Point(12, 145);
            this.monoFlat_Button9.Name = "monoFlat_Button9";
            this.monoFlat_Button9.Size = new System.Drawing.Size(664, 51);
            this.monoFlat_Button9.TabIndex = 2;
            this.monoFlat_Button9.Text = "MATEMATİK SORU CEVAP OYUNU(AĞ BAĞLANTISI GEREKTİRİR.)";
            this.monoFlat_Button9.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button9.Click += new System.EventHandler(this.monoFlat_Button9_Click);
            // 
            // monoFlat_Button7
            // 
            this.monoFlat_Button7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_Button7.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button7.Image = null;
            this.monoFlat_Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button7.Location = new System.Drawing.Point(12, 88);
            this.monoFlat_Button7.Name = "monoFlat_Button7";
            this.monoFlat_Button7.Size = new System.Drawing.Size(664, 51);
            this.monoFlat_Button7.TabIndex = 0;
            this.monoFlat_Button7.Text = "SAYILARI SONDAN BAŞA TAHMİN ETME";
            this.monoFlat_Button7.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button7.Click += new System.EventHandler(this.monoFlat_Button7_Click);
            // 
            // timer6
            // 
            this.timer6.Enabled = true;
            this.timer6.Interval = 1000;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Interval = 4200;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // timer8
            // 
            this.timer8.Enabled = true;
            this.timer8.Interval = 800;
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // timer9
            // 
            this.timer9.Interval = 780;
            this.timer9.Tick += new System.EventHandler(this.timer9_Tick);
            // 
            // timer10
            // 
            this.timer10.Tick += new System.EventHandler(this.timer10_Tick);
            // 
            // timer11
            // 
            this.timer11.Interval = 1000;
            this.timer11.Tick += new System.EventHandler(this.timer11_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(689, 436);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.Controls.Add(this.monoFlat_ThemeContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAKÜ     ZEKA     OYUNLARI    SETİ    v1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            this.monoFlat_ThemeContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_Button monoFlat_Button1;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_Button monoFlat_Button5;
        private MonoFlat.MonoFlat_Button monoFlat_Button4;
        private MonoFlat.MonoFlat_Button monoFlat_Button3;
        private MonoFlat.MonoFlat_Button monoFlat_Button2;
        private MonoFlat.MonoFlat_Label monoFlat_Label2;
        private MonoFlat.MonoFlat_Label monoFlat_Label3;
        private MonoFlat.MonoFlat_Button monoFlat_Button6;
        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer2;
        private MonoFlat.MonoFlat_Button monoFlat_Button11;
        private MonoFlat.MonoFlat_Button monoFlat_Button9;
        private MonoFlat.MonoFlat_Button monoFlat_Button7;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Timer timer9;
        private System.Windows.Forms.Timer timer10;
        private System.Windows.Forms.Timer timer11;
        private MonoFlat.MonoFlat_Button monoFlat_Button12;
        private MonoFlat.MonoFlat_Button monoFlat_Button13;
        private MonoFlat.MonoFlat_Button monoFlat_Button14;
        private MonoFlat.MonoFlat_Button monoFlat_Button15;
        private MonoFlat.MonoFlat_Button monoFlat_Button16;
    }
}

