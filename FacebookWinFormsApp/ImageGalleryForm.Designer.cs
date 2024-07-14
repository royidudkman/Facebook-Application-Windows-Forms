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
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonAddToFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelGallery
            // 
            this.flowLayoutPanelGallery.AutoScroll = true;
            this.flowLayoutPanelGallery.Location = new System.Drawing.Point(0, 58);
            this.flowLayoutPanelGallery.Name = "flowLayoutPanelGallery";
            this.flowLayoutPanelGallery.Size = new System.Drawing.Size(906, 472);
            this.flowLayoutPanelGallery.TabIndex = 0;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSelect.Location = new System.Drawing.Point(0, 0);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(906, 26);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonAddToFolder
            // 
            this.buttonAddToFolder.BackColor = System.Drawing.Color.Silver;
            this.buttonAddToFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddToFolder.ForeColor = System.Drawing.Color.Black;
            this.buttonAddToFolder.Location = new System.Drawing.Point(0, 26);
            this.buttonAddToFolder.Name = "buttonAddToFolder";
            this.buttonAddToFolder.Size = new System.Drawing.Size(906, 26);
            this.buttonAddToFolder.TabIndex = 5;
            this.buttonAddToFolder.Text = "Add to folder";
            this.buttonAddToFolder.UseVisualStyleBackColor = false;
            this.buttonAddToFolder.Visible = false;
            this.buttonAddToFolder.Click += new System.EventHandler(this.buttonAddToFolder_Click);
            // 
            // ImageGalleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 530);
            this.Controls.Add(this.buttonAddToFolder);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.flowLayoutPanelGallery);
            this.Name = "ImageGalleryForm";
            this.Text = "ImageGalleryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGallery;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonAddToFolder;
    }
}