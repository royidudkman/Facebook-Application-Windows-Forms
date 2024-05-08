namespace BasicFacebookFeatures
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelHead = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ButtonCreateBusinessCard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHead.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHead.Location = new System.Drawing.Point(196, 12);
            this.labelHead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(149, 33);
            this.labelHead.TabIndex = 0;
            this.labelHead.Text = "Hello User !";
            this.labelHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.button1.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(7, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "send happy Bday";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.ButtonCreateBusinessCard);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 190);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 102);
            this.panel1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.button3.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(383, 34);
            this.button3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "Create new Album";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ButtonCreateBusinessCard
            // 
            this.ButtonCreateBusinessCard.AutoSize = true;
            this.ButtonCreateBusinessCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ButtonCreateBusinessCard.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonCreateBusinessCard.Location = new System.Drawing.Point(195, 34);
            this.ButtonCreateBusinessCard.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButtonCreateBusinessCard.Name = "ButtonCreateBusinessCard";
            this.ButtonCreateBusinessCard.Size = new System.Drawing.Size(156, 25);
            this.ButtonCreateBusinessCard.TabIndex = 2;
            this.ButtonCreateBusinessCard.Text = "Create Business Card";
            this.ButtonCreateBusinessCard.UseVisualStyleBackColor = false;
            this.ButtonCreateBusinessCard.Click += new System.EventHandler(this.ButtonCreateBusinessCard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelHead);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ButtonCreateBusinessCard;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}