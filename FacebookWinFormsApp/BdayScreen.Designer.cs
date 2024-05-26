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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCustomGreed = new System.Windows.Forms.RadioButton();
            this.radioButtonGreetType3 = new System.Windows.Forms.RadioButton();
            this.radioButtonGreetType2 = new System.Windows.Forms.RadioButton();
            this.radioButtonGreetType1 = new System.Windows.Forms.RadioButton();
            this.listBoxUserFriends = new System.Windows.Forms.ListBox();
            this.buttonPostBlessing = new System.Windows.Forms.Button();
            this.richTextBoxGreeting = new System.Windows.Forms.RichTextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCustomGreed);
            this.groupBox1.Controls.Add(this.radioButtonGreetType3);
            this.groupBox1.Controls.Add(this.radioButtonGreetType2);
            this.groupBox1.Controls.Add(this.radioButtonGreetType1);
            this.groupBox1.Controls.Add(this.listBoxUserFriends);
            this.groupBox1.Controls.Add(this.buttonPostBlessing);
            this.groupBox1.Controls.Add(this.richTextBoxGreeting);
            this.groupBox1.Location = new System.Drawing.Point(8, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(517, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtonCustomGreed
            // 
            this.radioButtonCustomGreed.AutoSize = true;
            this.radioButtonCustomGreed.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonCustomGreed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonCustomGreed.Location = new System.Drawing.Point(201, 157);
            this.radioButtonCustomGreed.Name = "radioButtonCustomGreed";
            this.radioButtonCustomGreed.Size = new System.Drawing.Size(107, 17);
            this.radioButtonCustomGreed.TabIndex = 12;
            this.radioButtonCustomGreed.TabStop = true;
            this.radioButtonCustomGreed.Text = "Custom Greet";
            this.radioButtonCustomGreed.UseVisualStyleBackColor = true;
            this.radioButtonCustomGreed.CheckedChanged += new System.EventHandler(this.radioButtonGreetType_CheckedChanged);
            // 
            // radioButtonGreetType3
            // 
            this.radioButtonGreetType3.AutoSize = true;
            this.radioButtonGreetType3.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonGreetType3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonGreetType3.Location = new System.Drawing.Point(201, 127);
            this.radioButtonGreetType3.Name = "radioButtonGreetType3";
            this.radioButtonGreetType3.Size = new System.Drawing.Size(100, 17);
            this.radioButtonGreetType3.TabIndex = 11;
            this.radioButtonGreetType3.TabStop = true;
            this.radioButtonGreetType3.Text = "Greet Type 3";
            this.radioButtonGreetType3.UseVisualStyleBackColor = true;
            this.radioButtonGreetType3.CheckedChanged += new System.EventHandler(this.radioButtonGreetType_CheckedChanged);
            // 
            // radioButtonGreetType2
            // 
            this.radioButtonGreetType2.AutoSize = true;
            this.radioButtonGreetType2.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonGreetType2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonGreetType2.Location = new System.Drawing.Point(201, 98);
            this.radioButtonGreetType2.Name = "radioButtonGreetType2";
            this.radioButtonGreetType2.Size = new System.Drawing.Size(100, 17);
            this.radioButtonGreetType2.TabIndex = 10;
            this.radioButtonGreetType2.TabStop = true;
            this.radioButtonGreetType2.Text = "Greet Type 2";
            this.radioButtonGreetType2.UseVisualStyleBackColor = true;
            this.radioButtonGreetType2.CheckedChanged += new System.EventHandler(this.radioButtonGreetType_CheckedChanged);
            // 
            // radioButtonGreetType1
            // 
            this.radioButtonGreetType1.AutoSize = true;
            this.radioButtonGreetType1.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonGreetType1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonGreetType1.Location = new System.Drawing.Point(201, 68);
            this.radioButtonGreetType1.Name = "radioButtonGreetType1";
            this.radioButtonGreetType1.Size = new System.Drawing.Size(100, 17);
            this.radioButtonGreetType1.TabIndex = 9;
            this.radioButtonGreetType1.TabStop = true;
            this.radioButtonGreetType1.Text = "Greet Type 1";
            this.radioButtonGreetType1.UseVisualStyleBackColor = true;
            this.radioButtonGreetType1.CheckedChanged += new System.EventHandler(this.radioButtonGreetType_CheckedChanged);
            // 
            // listBoxUserFriends
            // 
            this.listBoxUserFriends.FormattingEnabled = true;
            this.listBoxUserFriends.Location = new System.Drawing.Point(35, 72);
            this.listBoxUserFriends.Name = "listBoxUserFriends";
            this.listBoxUserFriends.Size = new System.Drawing.Size(160, 95);
            this.listBoxUserFriends.TabIndex = 4;
            this.listBoxUserFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxUserFriends_SelectedIndexChanged);
            // 
            // buttonPostBlessing
            // 
            this.buttonPostBlessing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.buttonPostBlessing.Font = new System.Drawing.Font("Aharoni", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPostBlessing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPostBlessing.Location = new System.Drawing.Point(393, 198);
            this.buttonPostBlessing.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPostBlessing.Name = "buttonPostBlessing";
            this.buttonPostBlessing.Size = new System.Drawing.Size(120, 40);
            this.buttonPostBlessing.TabIndex = 2;
            this.buttonPostBlessing.Text = "Post the blessing";
            this.buttonPostBlessing.UseVisualStyleBackColor = false;
            this.buttonPostBlessing.Click += new System.EventHandler(this.buttonPostBlessing_Click);
            // 
            // richTextBoxGreeting
            // 
            this.richTextBoxGreeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
            this.richTextBoxGreeting.Location = new System.Drawing.Point(317, 72);
            this.richTextBoxGreeting.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxGreeting.Name = "richTextBoxGreeting";
            this.richTextBoxGreeting.Size = new System.Drawing.Size(179, 83);
            this.richTextBoxGreeting.TabIndex = 1;
            this.richTextBoxGreeting.Text = "";
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(549, 331);
            this.Name = "BdayScreen";
            this.Text = "BdayScreen";
            this.Load += new System.EventHandler(this.BdayScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPostBlessing;
        private System.Windows.Forms.RichTextBox richTextBoxGreeting;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxUserFriends;
        private System.Windows.Forms.RadioButton radioButtonCustomGreed;
        private System.Windows.Forms.RadioButton radioButtonGreetType3;
        private System.Windows.Forms.RadioButton radioButtonGreetType2;
        private System.Windows.Forms.RadioButton radioButtonGreetType1;
    }
}