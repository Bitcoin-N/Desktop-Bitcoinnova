namespace TurtleWallet
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splashBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.splashDrop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.splashDrop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.versionLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 551);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 30);
            this.panel1.TabIndex = 1;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(16, 0);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(384, 30);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Wallet opening ...";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // versionLabel
            // 
            this.versionLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.White;
            this.versionLabel.Location = new System.Drawing.Point(400, 0);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(70, 30);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "v 1.0.0.0";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 30);
            this.panel2.TabIndex = 0;
            // 
            // splashBackgroundWorker
            // 
            this.splashBackgroundWorker.WorkerReportsProgress = true;
            this.splashBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SplashBackgroundWorker_DoWork);
            this.splashBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.SplashBackgroundWorker_ProgressChanged);
            this.splashBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SplashBackgroundWorker_RunWorkerCompleted);
            // 
            // splashDrop
            // 
            this.splashDrop.BackgroundImage = global::TurtleWallet.Properties.Resources.back;
            this.splashDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splashDrop.Controls.Add(this.tableLayoutPanel1);
            this.splashDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splashDrop.Location = new System.Drawing.Point(0, 0);
            this.splashDrop.Margin = new System.Windows.Forms.Padding(2);
            this.splashDrop.MinimumSize = new System.Drawing.Size(15, 16);
            this.splashDrop.Name = "splashDrop";
            this.splashDrop.Size = new System.Drawing.Size(470, 551);
            this.splashDrop.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.179837F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.82016F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 551);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 367);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.label2.Size = new System.Drawing.Size(464, 112);
            this.label2.TabIndex = 2;
            this.label2.Text = "A New Innovative Way To Be The Definitive Cryptocurrency";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TurtleWallet.Properties.Resources.trtls;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(40, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 279);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(50, 487);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(50, 8, 50, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(370, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 9;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splashDrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitcoin Nova Wallet";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.panel1.ResumeLayout(false);
            this.splashDrop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.ComponentModel.BackgroundWorker splashBackgroundWorker;
        private System.Windows.Forms.Panel splashDrop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

