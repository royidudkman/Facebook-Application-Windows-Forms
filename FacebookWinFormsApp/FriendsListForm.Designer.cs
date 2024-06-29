namespace BasicFacebookFeatures
{
    partial class FriendsListForm
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
            this.panelFriendsDetails = new System.Windows.Forms.Panel();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.buttonTag = new System.Windows.Forms.Button();
            this.panelFriendsDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFriendsDetails
            // 
            this.panelFriendsDetails.Controls.Add(this.nameLabel1);
            this.panelFriendsDetails.Controls.Add(this.imageNormalPictureBox);
            this.panelFriendsDetails.Location = new System.Drawing.Point(169, 3);
            this.panelFriendsDetails.Name = "panelFriendsDetails";
            this.panelFriendsDetails.Size = new System.Drawing.Size(168, 161);
            this.panelFriendsDetails.TabIndex = 0;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.userBindingSource;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(3, 3);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(149, 225);
            this.listBoxFriends.TabIndex = 1;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(16, 3);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(137, 126);
            this.imageNormalPictureBox.TabIndex = 1;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(13, 132);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 2;
            this.nameLabel1.Text = "label1";
            // 
            // buttonTag
            // 
            this.buttonTag.Location = new System.Drawing.Point(185, 183);
            this.buttonTag.Name = "buttonTag";
            this.buttonTag.Size = new System.Drawing.Size(137, 36);
            this.buttonTag.TabIndex = 2;
            this.buttonTag.Text = "Tag";
            this.buttonTag.UseVisualStyleBackColor = true;
            this.buttonTag.Click += new System.EventHandler(this.buttonTag_Click);
            // 
            // FriendsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 231);
            this.Controls.Add(this.buttonTag);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.panelFriendsDetails);
            this.Name = "FriendsListForm";
            this.Text = "FriendsListForm";
            this.panelFriendsDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFriendsDetails;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Button buttonTag;
    }
}