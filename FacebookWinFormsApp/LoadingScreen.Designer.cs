namespace BasicFacebookFeatures
{
    partial class LoadingScreen
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
            this.labelLoading = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelPrecent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Aharoni", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLoading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLoading.Location = new System.Drawing.Point(8, 133);
            this.labelLoading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(237, 47);
            this.labelLoading.TabIndex = 0;
            this.labelLoading.Text = "Loading...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 218);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(398, 28);
            this.progressBar.TabIndex = 1;
            // 
            // labelPrecent
            // 
            this.labelPrecent.AutoSize = true;
            this.labelPrecent.Font = new System.Drawing.Font("Aharoni", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPrecent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPrecent.Location = new System.Drawing.Point(427, 213);
            this.labelPrecent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecent.Name = "labelPrecent";
            this.labelPrecent.Size = new System.Drawing.Size(30, 35);
            this.labelPrecent.TabIndex = 2;
            this.labelPrecent.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.labelPrecent);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelPrecent;
        private System.Windows.Forms.Timer timer1;
    }
}