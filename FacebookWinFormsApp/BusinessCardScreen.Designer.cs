namespace BasicFacebookFeatures
{
    partial class BusinessCardScreen
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
            this.checkedListBoxOptions = new System.Windows.Forms.CheckedListBox();
            this.richTextBoxPreview = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBoxOptions
            // 
            this.checkedListBoxOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.checkedListBoxOptions.FormattingEnabled = true;
            this.checkedListBoxOptions.Items.AddRange(new object[] {
            "Name",
            "Last Name",
            "Age",
            "Location",
            "Home Town",
            "Gender",
            "Link To Website"});
            this.checkedListBoxOptions.Location = new System.Drawing.Point(78, 72);
            this.checkedListBoxOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBoxOptions.Name = "checkedListBoxOptions";
            this.checkedListBoxOptions.Size = new System.Drawing.Size(122, 109);
            this.checkedListBoxOptions.TabIndex = 0;
            // 
            // richTextBoxPreview
            // 
            this.richTextBoxPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.richTextBoxPreview.Location = new System.Drawing.Point(311, 72);
            this.richTextBoxPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxPreview.Name = "richTextBoxPreview";
            this.richTextBoxPreview.Size = new System.Drawing.Size(187, 109);
            this.richTextBoxPreview.TabIndex = 1;
            this.richTextBoxPreview.Text = "here will be the Business Card";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.buttonSave.Font = new System.Drawing.Font("Aharoni", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSave.Location = new System.Drawing.Point(217, 209);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 38);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save ";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTitle.Location = new System.Drawing.Point(157, 14);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(211, 24);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Create Business Card";
            // 
            // BusinessCardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.richTextBoxPreview);
            this.Controls.Add(this.checkedListBoxOptions);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BusinessCardScreen";
            this.Text = "BusinessCardScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxOptions;
        private System.Windows.Forms.RichTextBox richTextBoxPreview;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTitle;
    }
}