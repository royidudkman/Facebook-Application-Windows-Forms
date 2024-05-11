namespace BasicFacebookFeatures
{
    partial class ImageAndTitleCardItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(27, 18);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(73, 63);
            this.pictureBoxProfilePicture.TabIndex = 0;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(106, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            // 
            // ImageAndTitleCardItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Name = "ImageAndTitleCardItem";
            this.Size = new System.Drawing.Size(364, 99);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Label labelName;
    }
}
