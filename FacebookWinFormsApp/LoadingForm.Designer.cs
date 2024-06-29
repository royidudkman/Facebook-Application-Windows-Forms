namespace BasicFacebookFeatures
{
    partial class LoadingForm
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
            this.lable_loading = new System.Windows.Forms.Label();
            this.progressBar_loading = new System.Windows.Forms.ProgressBar();
            this.label_precent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lable_loading
            // 
            this.lable_loading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lable_loading.AutoSize = true;
            this.lable_loading.BackColor = System.Drawing.Color.MidnightBlue;
            this.lable_loading.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lable_loading.Font = new System.Drawing.Font("Aharoni", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_loading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lable_loading.Location = new System.Drawing.Point(8, 94);
            this.lable_loading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable_loading.Name = "lable_loading";
            this.lable_loading.Size = new System.Drawing.Size(313, 63);
            this.lable_loading.TabIndex = 0;
            this.lable_loading.Text = "Loading...";
            // 
            // progressBar_loading
            // 
            this.progressBar_loading.ForeColor = System.Drawing.Color.Lime;
            this.progressBar_loading.Location = new System.Drawing.Point(19, 237);
            this.progressBar_loading.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar_loading.Name = "progressBar_loading";
            this.progressBar_loading.Size = new System.Drawing.Size(563, 27);
            this.progressBar_loading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_loading.TabIndex = 1;
            this.progressBar_loading.UseWaitCursor = true;
            // 
            // label_precent
            // 
            this.label_precent.AutoSize = true;
            this.label_precent.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_precent.ForeColor = System.Drawing.SystemColors.Control;
            this.label_precent.Location = new System.Drawing.Point(285, 207);
            this.label_precent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_precent.Name = "label_precent";
            this.label_precent.Size = new System.Drawing.Size(35, 24);
            this.label_precent.TabIndex = 2;
            this.label_precent.Text = "0%";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(599, 283);
            this.Controls.Add(this.label_precent);
            this.Controls.Add(this.progressBar_loading);
            this.Controls.Add(this.lable_loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable_loading;
        private System.Windows.Forms.ProgressBar progressBar_loading;
        private System.Windows.Forms.Label label_precent;
    }
}