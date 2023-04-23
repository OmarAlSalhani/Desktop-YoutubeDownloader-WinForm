namespace YoutubeDownloader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.eta_lbl = new System.Windows.Forms.Label();
            this.speed_lbl = new System.Windows.Forms.Label();
            this.ext_btn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.url_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.save_folder_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2ProgressIndicator1 = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.video_download_btn = new Guna.UI2.WinForms.Guna2Button();
            this.fpd_btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // eta_lbl
            // 
            this.eta_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.eta_lbl.AutoSize = true;
            this.eta_lbl.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.eta_lbl.ForeColor = System.Drawing.Color.Green;
            this.eta_lbl.Location = new System.Drawing.Point(259, 9);
            this.eta_lbl.Name = "eta_lbl";
            this.eta_lbl.Size = new System.Drawing.Size(15, 26);
            this.eta_lbl.TabIndex = 3;
            this.eta_lbl.Text = " ";
            // 
            // speed_lbl
            // 
            this.speed_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.speed_lbl.AutoSize = true;
            this.speed_lbl.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.speed_lbl.ForeColor = System.Drawing.Color.Green;
            this.speed_lbl.Location = new System.Drawing.Point(481, 9);
            this.speed_lbl.Name = "speed_lbl";
            this.speed_lbl.Size = new System.Drawing.Size(15, 26);
            this.speed_lbl.TabIndex = 4;
            this.speed_lbl.Text = " ";
            // 
            // ext_btn
            // 
            this.ext_btn.BackColor = System.Drawing.Color.Transparent;
            this.ext_btn.BorderRadius = 5;
            this.ext_btn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ext_btn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ext_btn.FocusedColor = System.Drawing.Color.Empty;
            this.ext_btn.FocusedState.Parent = this.ext_btn;
            this.ext_btn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ext_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ext_btn.FormattingEnabled = true;
            this.ext_btn.HoverState.Parent = this.ext_btn;
            this.ext_btn.ItemHeight = 30;
            this.ext_btn.ItemsAppearance.Parent = this.ext_btn;
            this.ext_btn.Location = new System.Drawing.Point(49, 83);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.ShadowDecoration.Parent = this.ext_btn;
            this.ext_btn.Size = new System.Drawing.Size(127, 36);
            this.ext_btn.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 10F);
            this.label3.Location = new System.Drawing.Point(126, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "الصيغة";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Red;
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.Red;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(621, 35);
            this.guna2Panel1.TabIndex = 7;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(580, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 29);
            this.guna2ControlBox1.TabIndex = 8;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            // 
            // url_tb
            // 
            this.url_tb.Animated = true;
            this.url_tb.BorderRadius = 5;
            this.url_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.url_tb.DefaultText = "";
            this.url_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.url_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.url_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.url_tb.DisabledState.Parent = this.url_tb;
            this.url_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.url_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.url_tb.FocusedState.Parent = this.url_tb;
            this.url_tb.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.url_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.url_tb.HoverState.Parent = this.url_tb;
            this.url_tb.Location = new System.Drawing.Point(182, 83);
            this.url_tb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.url_tb.Name = "url_tb";
            this.url_tb.PasswordChar = '\0';
            this.url_tb.PlaceholderText = "رابط الفيديو";
            this.url_tb.SelectedText = "";
            this.url_tb.ShadowDecoration.Parent = this.url_tb;
            this.url_tb.Size = new System.Drawing.Size(421, 36);
            this.url_tb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 10F);
            this.label4.Location = new System.Drawing.Point(523, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "رابط الفيديو";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(198, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salhani Youtube Downloader";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 10F);
            this.label6.Location = new System.Drawing.Point(487, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "مسار حفظ الفيديو";
            // 
            // save_folder_tb
            // 
            this.save_folder_tb.Animated = true;
            this.save_folder_tb.BorderRadius = 5;
            this.save_folder_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.save_folder_tb.DefaultText = "";
            this.save_folder_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.save_folder_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.save_folder_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.save_folder_tb.DisabledState.Parent = this.save_folder_tb;
            this.save_folder_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.save_folder_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.save_folder_tb.FocusedState.Parent = this.save_folder_tb;
            this.save_folder_tb.Font = new System.Drawing.Font("Cairo", 10F);
            this.save_folder_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.save_folder_tb.HoverState.Parent = this.save_folder_tb;
            this.save_folder_tb.Location = new System.Drawing.Point(49, 154);
            this.save_folder_tb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.save_folder_tb.Name = "save_folder_tb";
            this.save_folder_tb.PasswordChar = '\0';
            this.save_folder_tb.PlaceholderText = "رابط الفيديو";
            this.save_folder_tb.SelectedText = "";
            this.save_folder_tb.ShadowDecoration.Parent = this.save_folder_tb;
            this.save_folder_tb.Size = new System.Drawing.Size(549, 36);
            this.save_folder_tb.TabIndex = 13;
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.BorderRadius = 5;
            this.guna2ProgressBar1.Font = new System.Drawing.Font("Arial", 9F);
            this.guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(82, 198);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.Green;
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.Green;
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.ShowPercentage = true;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(485, 20);
            this.guna2ProgressBar1.TabIndex = 17;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.speed_lbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.eta_lbl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 40);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.Controls.Add(this.tableLayoutPanel1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(2, 309);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(617, 86);
            this.guna2GroupBox1.TabIndex = 19;
            this.guna2GroupBox1.Text = "معلومات التحميل";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 10F);
            this.label1.Location = new System.Drawing.Point(502, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "سرعة التحميل :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10F);
            this.label2.Location = new System.Drawing.Point(280, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "الوقت المتبقي :";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 5;
            this.guna2GroupBox2.Controls.Add(this.guna2PictureBox1);
            this.guna2GroupBox2.Controls.Add(this.guna2ProgressIndicator1);
            this.guna2GroupBox2.Controls.Add(this.url_tb);
            this.guna2GroupBox2.Controls.Add(this.label4);
            this.guna2GroupBox2.Controls.Add(this.video_download_btn);
            this.guna2GroupBox2.Controls.Add(this.guna2ProgressBar1);
            this.guna2GroupBox2.Controls.Add(this.ext_btn);
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.Controls.Add(this.fpd_btn);
            this.guna2GroupBox2.Controls.Add(this.save_folder_tb);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(2, 37);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(617, 270);
            this.guna2GroupBox2.TabIndex = 20;
            this.guna2GroupBox2.Text = "تحميل الفيديو";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo", 10F);
            this.label7.Location = new System.Drawing.Point(99, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "حجم الفيديو :";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(78, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 26);
            this.label10.TabIndex = 25;
            this.label10.Text = " ";
            // 
            // guna2ProgressIndicator1
            // 
            this.guna2ProgressIndicator1.AutoStart = true;
            this.guna2ProgressIndicator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ProgressIndicator1.CircleSize = 1F;
            this.guna2ProgressIndicator1.Location = new System.Drawing.Point(231, 54);
            this.guna2ProgressIndicator1.Name = "guna2ProgressIndicator1";
            this.guna2ProgressIndicator1.ProgressColor = System.Drawing.Color.Red;
            this.guna2ProgressIndicator1.Size = new System.Drawing.Size(152, 152);
            this.guna2ProgressIndicator1.TabIndex = 18;
            this.guna2ProgressIndicator1.UseTransparentBackground = true;
            this.guna2ProgressIndicator1.Visible = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::YoutubeDownloader.Properties.Resources.youtube_2_;
            this.guna2PictureBox1.Location = new System.Drawing.Point(483, 50);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(42, 31);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 19;
            this.guna2PictureBox1.TabStop = false;
            // 
            // video_download_btn
            // 
            this.video_download_btn.BorderRadius = 5;
            this.video_download_btn.CheckedState.Parent = this.video_download_btn;
            this.video_download_btn.CustomImages.Parent = this.video_download_btn;
            this.video_download_btn.FillColor = System.Drawing.Color.Red;
            this.video_download_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.video_download_btn.ForeColor = System.Drawing.Color.White;
            this.video_download_btn.HoverState.Parent = this.video_download_btn;
            this.video_download_btn.Image = global::YoutubeDownloader.Properties.Resources.youtube_1_;
            this.video_download_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.video_download_btn.Location = new System.Drawing.Point(505, 228);
            this.video_download_btn.Name = "video_download_btn";
            this.video_download_btn.ShadowDecoration.Parent = this.video_download_btn;
            this.video_download_btn.Size = new System.Drawing.Size(93, 38);
            this.video_download_btn.TabIndex = 16;
            this.video_download_btn.Text = "تحميل";
            this.video_download_btn.Click += new System.EventHandler(this.video_download_btn_Click);
            // 
            // fpd_btn
            // 
            this.fpd_btn.CheckedState.Parent = this.fpd_btn;
            this.fpd_btn.HoverState.Parent = this.fpd_btn;
            this.fpd_btn.Image = global::YoutubeDownloader.Properties.Resources.folder_1_;
            this.fpd_btn.ImageSize = new System.Drawing.Size(35, 35);
            this.fpd_btn.Location = new System.Drawing.Point(3, 154);
            this.fpd_btn.Name = "fpd_btn";
            this.fpd_btn.PressedState.Parent = this.fpd_btn;
            this.fpd_btn.Size = new System.Drawing.Size(40, 36);
            this.fpd_btn.TabIndex = 15;
            this.fpd_btn.Click += new System.EventHandler(this.fpd_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 398);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label eta_lbl;
        private System.Windows.Forms.Label speed_lbl;
        private Guna.UI2.WinForms.Guna2ComboBox ext_btn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox url_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ImageButton fpd_btn;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox save_folder_tb;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Guna.UI2.WinForms.Guna2Button video_download_btn;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ProgressIndicator guna2ProgressIndicator1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

