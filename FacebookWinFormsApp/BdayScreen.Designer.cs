namespace BasicFacebookFeatures
{
    partial class BdayScreen
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewFriends = new System.Windows.Forms.ListView();
            this.Friends = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonPostBlessing = new System.Windows.Forms.Button();
            this.richTextBoxPreview = new System.Windows.Forms.RichTextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewFriends);
            this.groupBox1.Controls.Add(this.buttonPostBlessing);
            this.groupBox1.Controls.Add(this.richTextBoxPreview);
            this.groupBox1.Location = new System.Drawing.Point(8, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(517, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listViewFriends
            // 
            this.listViewFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
            this.listViewFriends.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Friends,
            this.columnHeader2});
            this.listViewFriends.HideSelection = false;
            this.listViewFriends.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listViewFriends.Location = new System.Drawing.Point(87, 72);
            this.listViewFriends.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewFriends.Name = "listViewFriends";
            this.listViewFriends.Size = new System.Drawing.Size(98, 83);
            this.listViewFriends.TabIndex = 3;
            this.listViewFriends.UseCompatibleStateImageBehavior = false;
            this.listViewFriends.View = System.Windows.Forms.View.Details;
            // 
            // Friends
            // 
            this.Friends.Text = "Friends";
            this.Friends.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gender";
            this.columnHeader2.Width = 71;
            // 
            // buttonPostBlessing
            // 
            this.buttonPostBlessing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.buttonPostBlessing.Font = new System.Drawing.Font("Aharoni", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPostBlessing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPostBlessing.Location = new System.Drawing.Point(393, 198);
            this.buttonPostBlessing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPostBlessing.Name = "buttonPostBlessing";
            this.buttonPostBlessing.Size = new System.Drawing.Size(120, 40);
            this.buttonPostBlessing.TabIndex = 2;
            this.buttonPostBlessing.Text = "Post the blessing";
            this.buttonPostBlessing.UseVisualStyleBackColor = false;
            // 
            // richTextBoxPreview
            // 
            this.richTextBoxPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
            this.richTextBoxPreview.Location = new System.Drawing.Point(244, 72);
            this.richTextBoxPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxPreview.Name = "richTextBoxPreview";
            this.richTextBoxPreview.Size = new System.Drawing.Size(179, 83);
            this.richTextBoxPreview.TabIndex = 1;
            this.richTextBoxPreview.Text = "preview";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitle.Location = new System.Drawing.Point(108, 6);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(335, 24);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Send Happy Bday To Your Friends";
            // 
            // BdayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "BdayScreen";
            this.Text = "BdayScreen";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPostBlessing;
        private System.Windows.Forms.RichTextBox richTextBoxPreview;
        private System.Windows.Forms.ListView listViewFriends;
        private System.Windows.Forms.ColumnHeader Friends;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label labelTitle;
    }
}