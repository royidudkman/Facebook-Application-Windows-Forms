namespace BasicFacebookFeatures
{
    partial class LoadingSpinner
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
            this.pictureBoxLoadindSpinner = new System.Windows.Forms.PictureBox();
            this.labelLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadindSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLoadindSpinner
            // 
            this.pictureBoxLoadindSpinner.Image = global::BasicFacebookFeatures.Properties.Resources.Spinner_1x_1_0s_200px_200px__3_;
            this.pictureBoxLoadindSpinner.Location = new System.Drawing.Point(82, 93);
            this.pictureBoxLoadindSpinner.Name = "pictureBoxLoadindSpinner";
            this.pictureBoxLoadindSpinner.Size = new System.Drawing.Size(163, 162);
            this.pictureBoxLoadindSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoadindSpinner.TabIndex = 0;
            this.pictureBoxLoadindSpinner.TabStop = false;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Aharoni", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLoading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLoading.Location = new System.Drawing.Point(75, 28);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(197, 39);
            this.labelLoading.TabIndex = 1;
            this.labelLoading.Text = "Loading...";
            // 
            // LoadingSpinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(340, 314);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.pictureBoxLoadindSpinner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingSpinner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingSpinner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadindSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLoadindSpinner;
        private System.Windows.Forms.Label labelLoading;
    }
}