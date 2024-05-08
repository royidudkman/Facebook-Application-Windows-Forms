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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSendHappyBirthday = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCreateNewAlbum = new System.Windows.Forms.Button();
            this.ButtonCreateBusinessCard = new System.Windows.Forms.Button();
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(196, 12);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(149, 33);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Hello User !";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSendHappyBirthday
            // 
            this.buttonSendHappyBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.buttonSendHappyBirthday.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSendHappyBirthday.Location = new System.Drawing.Point(5, 34);
            this.buttonSendHappyBirthday.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonSendHappyBirthday.Name = "buttonSendHappyBirthday";
            this.buttonSendHappyBirthday.Size = new System.Drawing.Size(131, 25);
            this.buttonSendHappyBirthday.TabIndex = 1;
            this.buttonSendHappyBirthday.Text = "send happy Bday";
            this.buttonSendHappyBirthday.UseVisualStyleBackColor = false;
            this.buttonSendHappyBirthday.Click += new System.EventHandler(this.buttonSendHappyBirthday_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonCreateNewAlbum);
            this.panel1.Controls.Add(this.ButtonCreateBusinessCard);
            this.panel1.Controls.Add(this.buttonSendHappyBirthday);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 190);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 102);
            this.panel1.TabIndex = 4;
            // 
            // buttonCreateNewAlbum
            // 
            this.buttonCreateNewAlbum.AutoSize = true;
            this.buttonCreateNewAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.buttonCreateNewAlbum.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonCreateNewAlbum.Location = new System.Drawing.Point(383, 34);
            this.buttonCreateNewAlbum.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonCreateNewAlbum.Name = "buttonCreateNewAlbum";
            this.buttonCreateNewAlbum.Size = new System.Drawing.Size(141, 25);
            this.buttonCreateNewAlbum.TabIndex = 3;
            this.buttonCreateNewAlbum.Text = "Create new Album";
            this.buttonCreateNewAlbum.UseVisualStyleBackColor = false;
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
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserProfile.Image")));
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(217, 75);
            this.pictureBoxUserProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(92, 79);
            this.pictureBoxUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserProfile.TabIndex = 5;
            this.pictureBoxUserProfile.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.pictureBoxUserProfile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSendHappyBirthday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCreateNewAlbum;
        private System.Windows.Forms.Button ButtonCreateBusinessCard;
        private System.Windows.Forms.PictureBox pictureBoxUserProfile;
    }
}