namespace BasicFacebookFeatures
{
    partial class AlbumsCreateScreen
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
            this.comboBoxAlbums = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonCreateAlbum = new System.Windows.Forms.Button();
            this.buttonSetAlbum = new System.Windows.Forms.Button();
            this.pictureAlbum = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAlbums
            // 
            this.comboBoxAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.comboBoxAlbums.FormattingEnabled = true;
            this.comboBoxAlbums.Location = new System.Drawing.Point(0, 0);
            this.comboBoxAlbums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAlbums.Name = "comboBoxAlbums";
            this.comboBoxAlbums.Size = new System.Drawing.Size(135, 21);
            this.comboBoxAlbums.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTitle.Location = new System.Drawing.Point(179, 18);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(137, 24);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Create Album";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(2, 22);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(133, 186);
            this.listBoxAlbums.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.buttonCreateAlbum);
            this.panel1.Controls.Add(this.buttonSetAlbum);
            this.panel1.Controls.Add(this.pictureAlbum);
            this.panel1.Controls.Add(this.comboBoxAlbums);
            this.panel1.Controls.Add(this.listBoxAlbums);
            this.panel1.Location = new System.Drawing.Point(2, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 216);
            this.panel1.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.labelName.Location = new System.Drawing.Point(213, 5);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Image Name";
            // 
            // buttonCreateAlbum
            // 
            this.buttonCreateAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.buttonCreateAlbum.Font = new System.Drawing.Font("Aharoni", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonCreateAlbum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreateAlbum.Location = new System.Drawing.Point(365, 104);
            this.buttonCreateAlbum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateAlbum.Name = "buttonCreateAlbum";
            this.buttonCreateAlbum.Size = new System.Drawing.Size(113, 22);
            this.buttonCreateAlbum.TabIndex = 4;
            this.buttonCreateAlbum.Text = "Create Album ";
            this.buttonCreateAlbum.UseVisualStyleBackColor = false;
            // 
            // buttonSetAlbum
            // 
            this.buttonSetAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.buttonSetAlbum.Font = new System.Drawing.Font("Aharoni", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSetAlbum.Location = new System.Drawing.Point(355, 68);
            this.buttonSetAlbum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSetAlbum.Name = "buttonSetAlbum";
            this.buttonSetAlbum.Size = new System.Drawing.Size(130, 22);
            this.buttonSetAlbum.TabIndex = 3;
            this.buttonSetAlbum.Text = "Set Album Properties";
            this.buttonSetAlbum.UseVisualStyleBackColor = false;
            // 
            // pictureAlbum
            // 
            this.pictureAlbum.Image = global::BasicFacebookFeatures.Properties.Resources.facebook_logo;
            this.pictureAlbum.Location = new System.Drawing.Point(138, 22);
            this.pictureAlbum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureAlbum.Name = "pictureAlbum";
            this.pictureAlbum.Size = new System.Drawing.Size(205, 185);
            this.pictureAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAlbum.TabIndex = 2;
            this.pictureAlbum.TabStop = false;
            // 
            // AlbumsCreateScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AlbumsCreateScreen";
            this.Text = "AlbumsCreateScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAlbums;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureAlbum;
        private System.Windows.Forms.Button buttonCreateAlbum;
        private System.Windows.Forms.Button buttonSetAlbum;
        private System.Windows.Forms.Label labelName;
    }
}