namespace DHF
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.prgSplash = new System.Windows.Forms.ProgressBar();
            this.tmrProgresso = new System.Windows.Forms.Timer(this.components);
            this.tmrNoz = new System.Windows.Forms.Timer(this.components);
            this.picNoz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNoz)).BeginInit();
            this.SuspendLayout();
            // 
            // prgSplash
            // 
            this.prgSplash.BackColor = System.Drawing.Color.Lavender;
            this.prgSplash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prgSplash.Location = new System.Drawing.Point(0, 457);
            this.prgSplash.Name = "prgSplash";
            this.prgSplash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prgSplash.Size = new System.Drawing.Size(640, 23);
            this.prgSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgSplash.TabIndex = 0;
            this.prgSplash.Click += new System.EventHandler(this.prgSplash_Click);
            // 
            // tmrProgresso
            // 
            this.tmrProgresso.Enabled = true;
            this.tmrProgresso.Interval = 630;
            this.tmrProgresso.Tick += new System.EventHandler(this.tmrProgresso_Tick);
            // 
            // tmrNoz
            // 
            this.tmrNoz.Enabled = true;
            this.tmrNoz.Interval = 10;
            this.tmrNoz.Tick += new System.EventHandler(this.tmrNoz_Tick);
            // 
            // picNoz
            // 
            this.picNoz.BackColor = System.Drawing.Color.Transparent;
            this.picNoz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picNoz.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picNoz.ErrorImage")));
            this.picNoz.Image = ((System.Drawing.Image)(resources.GetObject("picNoz.Image")));
            this.picNoz.InitialImage = ((System.Drawing.Image)(resources.GetObject("picNoz.InitialImage")));
            this.picNoz.Location = new System.Drawing.Point(-10, 416);
            this.picNoz.Name = "picNoz";
            this.picNoz.Size = new System.Drawing.Size(32, 35);
            this.picNoz.TabIndex = 1;
            this.picNoz.TabStop = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.picNoz);
            this.Controls.Add(this.prgSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNoz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgSplash;
        private System.Windows.Forms.Timer tmrProgresso;
        private System.Windows.Forms.Timer tmrNoz;
        private System.Windows.Forms.PictureBox picNoz;
    }
}