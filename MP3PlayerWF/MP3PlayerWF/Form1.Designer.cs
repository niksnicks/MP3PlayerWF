namespace MP3PlayerWF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnWrap = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnVolumMute = new System.Windows.Forms.Button();
            this.btnSoundCtr = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btmForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(388, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(12, 81);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(45, 31);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(90, 81);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(45, 31);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(161, 81);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(45, 31);
            this.btnPause.TabIndex = 3;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(212, 81);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(45, 31);
            this.btnStop.TabIndex = 4;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnWrap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 27);
            this.panel1.TabIndex = 6;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(337, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 31);
            this.btnMinimize.TabIndex = 15;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnWrap
            // 
            this.btnWrap.BackColor = System.Drawing.Color.Transparent;
            this.btnWrap.FlatAppearance.BorderSize = 0;
            this.btnWrap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWrap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWrap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrap.Image = ((System.Drawing.Image)(resources.GetObject("btnWrap.Image")));
            this.btnWrap.Location = new System.Drawing.Point(286, 0);
            this.btnWrap.Name = "btnWrap";
            this.btnWrap.Size = new System.Drawing.Size(45, 31);
            this.btnWrap.TabIndex = 14;
            this.btnWrap.UseVisualStyleBackColor = false;
            this.btnWrap.Click += new System.EventHandler(this.btnWrap_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Gold;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.Location = new System.Drawing.Point(263, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 117);
            this.listBox1.TabIndex = 7;
            // 
            // btnVolumMute
            // 
            this.btnVolumMute.BackColor = System.Drawing.Color.Transparent;
            this.btnVolumMute.FlatAppearance.BorderSize = 0;
            this.btnVolumMute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolumMute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolumMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumMute.Image = ((System.Drawing.Image)(resources.GetObject("btnVolumMute.Image")));
            this.btnVolumMute.Location = new System.Drawing.Point(12, 144);
            this.btnVolumMute.Name = "btnVolumMute";
            this.btnVolumMute.Size = new System.Drawing.Size(55, 31);
            this.btnVolumMute.TabIndex = 9;
            this.btnVolumMute.UseVisualStyleBackColor = false;
            this.btnVolumMute.Click += new System.EventHandler(this.btnVolumMute_Click);
            // 
            // btnSoundCtr
            // 
            this.btnSoundCtr.BackColor = System.Drawing.Color.Transparent;
            this.btnSoundCtr.FlatAppearance.BorderSize = 0;
            this.btnSoundCtr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSoundCtr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSoundCtr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoundCtr.Image = ((System.Drawing.Image)(resources.GetObject("btnSoundCtr.Image")));
            this.btnSoundCtr.Location = new System.Drawing.Point(90, 155);
            this.btnSoundCtr.Name = "btnSoundCtr";
            this.btnSoundCtr.Size = new System.Drawing.Size(20, 20);
            this.btnSoundCtr.TabIndex = 12;
            this.btnSoundCtr.UseVisualStyleBackColor = false;
            this.btnSoundCtr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSoundCtr_MouseDown);
            this.btnSoundCtr.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSoundCtr_MouseMove);
            this.btnSoundCtr.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSoundCtr_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 18);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btmForward
            // 
            this.btmForward.BackColor = System.Drawing.Color.Transparent;
            this.btmForward.FlatAppearance.BorderSize = 0;
            this.btmForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btmForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btmForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmForward.Image = ((System.Drawing.Image)(resources.GetObject("btmForward.Image")));
            this.btmForward.Location = new System.Drawing.Point(127, 73);
            this.btmForward.Name = "btmForward";
            this.btmForward.Size = new System.Drawing.Size(41, 39);
            this.btmForward.TabIndex = 14;
            this.btmForward.UseVisualStyleBackColor = false;
            this.btmForward.Click += new System.EventHandler(this.btmForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(53, 81);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 31);
            this.btnBack.TabIndex = 15;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(433, 200);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btmForward);
            this.Controls.Add(this.btnSoundCtr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVolumMute);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PlayerWF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnVolumMute;
        private System.Windows.Forms.Button btnSoundCtr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnWrap;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btmForward;
        private System.Windows.Forms.Button btnBack;
    }
}

