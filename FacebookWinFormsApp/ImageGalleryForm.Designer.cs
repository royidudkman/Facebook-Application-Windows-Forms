namespace BasicFacebookFeatures
{
    partial class ImageGalleryForm
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
            this.flowLayoutPanelGallery = new System.Windows.Forms.FlowLayoutPanel();
            this.labelLoading = new System.Windows.Forms.Label();
            this.flowLayoutPanelGallery.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelGallery
            // 
            this.flowLayoutPanelGallery.AutoScroll = true;
            this.flowLayoutPanelGallery.Controls.Add(this.labelLoading);
            this.flowLayoutPanelGallery.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGallery.Name = "flowLayoutPanelGallery";
            this.flowLayoutPanelGallery.Size = new System.Drawing.Size(906, 530);
            this.flowLayoutPanelGallery.TabIndex = 0;
            // 
            // labelLoading
            // 
            this.labelLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.Location = new System.Drawing.Point(3, 0);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(247, 24);
            this.labelLoading.TabIndex = 0;
            this.labelLoading.Text = "Loading images, please wait";
            // 
            // ImageGalleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 530);
            this.Controls.Add(this.flowLayoutPanelGallery);
            this.Name = "ImageGalleryForm";
            this.Text = "ImageGalleryForm";
            this.flowLayoutPanelGallery.ResumeLayout(false);
            this.flowLayoutPanelGallery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGallery;
        private System.Windows.Forms.Label labelLoading;
    }
}