namespace app1
{
    partial class homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            this.close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titlepar = new System.Windows.Forms.PictureBox();
            this.homepar = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlepar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homepar)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Green;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("OCR-A BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.close.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.close.Location = new System.Drawing.Point(978, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 21);
            this.close.TabIndex = 10;
            this.close.Text = "x";
            this.close.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("OCR-A BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(923, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 21);
            this.button1.TabIndex = 13;
            this.button1.Text = "-";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.minimize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(22, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "AL WERD";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("OCR-A BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(952, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 21);
            this.button2.TabIndex = 15;
            this.button2.Text = "+";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.maxinormal_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(411, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 40);
            this.label1.TabIndex = 16;
            this.label1.Text = "AL WERD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::app1.Properties.Resources.شس;
            this.pictureBox1.Location = new System.Drawing.Point(2, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 650);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // titlepar
            // 
            this.titlepar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.titlepar.Location = new System.Drawing.Point(-40, 0);
            this.titlepar.Name = "titlepar";
            this.titlepar.Size = new System.Drawing.Size(1400, 21);
            this.titlepar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.titlepar.TabIndex = 8;
            this.titlepar.TabStop = false;
            this.titlepar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlepar_MouseDown);
            this.titlepar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlepar_MouseMove);
            // 
            // homepar
            // 
            this.homepar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.homepar.Location = new System.Drawing.Point(-40, 21);
            this.homepar.Name = "homepar";
            this.homepar.Size = new System.Drawing.Size(1500, 61);
            this.homepar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.homepar.TabIndex = 0;
            this.homepar.TabStop = false;
            this.homepar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.homepar_MouseDown);
            this.homepar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.homepar_MouseMove);
            // 
            // logout
            // 
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logout.Location = new System.Drawing.Point(2, 24);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(71, 55);
            this.logout.TabIndex = 18;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1000, 788);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.titlepar);
            this.Controls.Add(this.homepar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "homepage";
            this.Text = "homepage";
            this.Load += new System.EventHandler(this.homepage_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.homepage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.homepage_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlepar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homepar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox homepar;
        private System.Windows.Forms.PictureBox titlepar;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout;
    }
}