namespace BasicFacebookFeatures
{
    partial class CreatePostForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonChangeBackground = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonTagFriend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Aharoni", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(148, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(186, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Create Post";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 44);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(473, 264);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(152, 321);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(75, 23);
            this.buttonAddImage.TabIndex = 2;
            this.buttonAddImage.Text = "Add Image";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // buttonChangeBackground
            // 
            this.buttonChangeBackground.Location = new System.Drawing.Point(314, 321);
            this.buttonChangeBackground.Name = "buttonChangeBackground";
            this.buttonChangeBackground.Size = new System.Drawing.Size(112, 23);
            this.buttonChangeBackground.TabIndex = 4;
            this.buttonChangeBackground.Text = "Change background";
            this.buttonChangeBackground.UseVisualStyleBackColor = true;
            this.buttonChangeBackground.Click += new System.EventHandler(this.buttonChangeBackground_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add to your post:";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(410, 388);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 6;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonTagFriend
            // 
            this.buttonTagFriend.Location = new System.Drawing.Point(233, 321);
            this.buttonTagFriend.Name = "buttonTagFriend";
            this.buttonTagFriend.Size = new System.Drawing.Size(75, 23);
            this.buttonTagFriend.TabIndex = 3;
            this.buttonTagFriend.Text = "Tag Friends";
            this.buttonTagFriend.UseVisualStyleBackColor = true;
            this.buttonTagFriend.Click += new System.EventHandler(this.buttonTagFriend_Click);
            // 
            // CreatePostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 423);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChangeBackground);
            this.Controls.Add(this.buttonTagFriend);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.labelTitle);
            this.MaximumSize = new System.Drawing.Size(513, 462);
            this.MinimumSize = new System.Drawing.Size(513, 462);
            this.Name = "CreatePostForm";
            this.Text = "CreatePost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonChangeBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonTagFriend;
    }
}