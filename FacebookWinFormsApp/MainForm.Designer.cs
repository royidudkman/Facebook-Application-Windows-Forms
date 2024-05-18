namespace BasicFacebookFeatures
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSendHappyBirthday = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonCreateNewAlbum = new System.Windows.Forms.Button();
            this.ButtonCreateBusinessCard = new System.Windows.Forms.Button();
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.tabControlFeed = new System.Windows.Forms.TabControl();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPageFriends = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelFriends = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPagePictures = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelPictures = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageLikedPages = new System.Windows.Forms.TabPage();
            this.flowLayoutLikedPages = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageTeams = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelTeams = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelAbout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            this.tabControlFeed.SuspendLayout();
            this.tabPagePosts.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageFriends.SuspendLayout();
            this.tabPagePictures.SuspendLayout();
            this.tabPageLikedPages.SuspendLayout();
            this.tabPageTeams.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(86, 11);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(149, 33);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Hello User !";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSendHappyBirthday
            // 
            this.buttonSendHappyBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSendHappyBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.buttonSendHappyBirthday.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSendHappyBirthday.Location = new System.Drawing.Point(7, 31);
            this.buttonSendHappyBirthday.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonSendHappyBirthday.Name = "buttonSendHappyBirthday";
            this.buttonSendHappyBirthday.Size = new System.Drawing.Size(131, 25);
            this.buttonSendHappyBirthday.TabIndex = 1;
            this.buttonSendHappyBirthday.Text = "send happy Bday";
            this.buttonSendHappyBirthday.UseVisualStyleBackColor = false;
            this.buttonSendHappyBirthday.Click += new System.EventHandler(this.buttonSendHappyBirthday_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.buttonCreateNewAlbum);
            this.panel1.Controls.Add(this.ButtonCreateBusinessCard);
            this.panel1.Controls.Add(this.buttonSendHappyBirthday);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 573);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 102);
            this.panel1.TabIndex = 4;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.AutoSize = true;
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.buttonLogout.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Red;
            this.buttonLogout.Location = new System.Drawing.Point(620, 28);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(141, 30);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonCreateNewAlbum
            // 
            this.buttonCreateNewAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateNewAlbum.AutoSize = true;
            this.buttonCreateNewAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.buttonCreateNewAlbum.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonCreateNewAlbum.Location = new System.Drawing.Point(408, 28);
            this.buttonCreateNewAlbum.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonCreateNewAlbum.Name = "buttonCreateNewAlbum";
            this.buttonCreateNewAlbum.Size = new System.Drawing.Size(194, 30);
            this.buttonCreateNewAlbum.TabIndex = 3;
            this.buttonCreateNewAlbum.Text = "Create new Album";
            this.buttonCreateNewAlbum.UseVisualStyleBackColor = false;
            this.buttonCreateNewAlbum.Click += new System.EventHandler(this.buttonCreateNewAlbum_Click);
            // 
            // ButtonCreateBusinessCard
            // 
            this.ButtonCreateBusinessCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonCreateBusinessCard.AutoSize = true;
            this.ButtonCreateBusinessCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ButtonCreateBusinessCard.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonCreateBusinessCard.Location = new System.Drawing.Point(187, 31);
            this.ButtonCreateBusinessCard.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButtonCreateBusinessCard.Name = "ButtonCreateBusinessCard";
            this.ButtonCreateBusinessCard.Size = new System.Drawing.Size(215, 30);
            this.ButtonCreateBusinessCard.TabIndex = 2;
            this.ButtonCreateBusinessCard.Text = "Create Business Card";
            this.ButtonCreateBusinessCard.UseVisualStyleBackColor = false;
            this.ButtonCreateBusinessCard.Click += new System.EventHandler(this.ButtonCreateBusinessCard_Click);
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserProfile.Image")));
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(11, 11);
            this.pictureBoxUserProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(59, 48);
            this.pictureBoxUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserProfile.TabIndex = 5;
            this.pictureBoxUserProfile.TabStop = false;
            // 
            // tabControlFeed
            // 
            this.tabControlFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlFeed.Controls.Add(this.tabPagePosts);
            this.tabControlFeed.Controls.Add(this.tabPageAbout);
            this.tabControlFeed.Controls.Add(this.tabPageFriends);
            this.tabControlFeed.Controls.Add(this.tabPagePictures);
            this.tabControlFeed.Controls.Add(this.tabPageLikedPages);
            this.tabControlFeed.Controls.Add(this.tabPageTeams);
            this.tabControlFeed.ItemSize = new System.Drawing.Size(42, 18);
            this.tabControlFeed.Location = new System.Drawing.Point(17, 82);
            this.tabControlFeed.Name = "tabControlFeed";
            this.tabControlFeed.SelectedIndex = 0;
            this.tabControlFeed.Size = new System.Drawing.Size(721, 467);
            this.tabControlFeed.TabIndex = 6;
            // 
            // tabPagePosts
            // 
            this.tabPagePosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.tabPagePosts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagePosts.Controls.Add(this.flowLayoutPanelPosts);
            this.tabPagePosts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPagePosts.Location = new System.Drawing.Point(4, 22);
            this.tabPagePosts.Name = "tabPagePosts";
            this.tabPagePosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePosts.Size = new System.Drawing.Size(713, 441);
            this.tabPagePosts.TabIndex = 0;
            this.tabPagePosts.Text = "Posts";
            // 
            // flowLayoutPanelPosts
            // 
            this.flowLayoutPanelPosts.AutoScroll = true;
            this.flowLayoutPanelPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPosts.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelPosts.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelPosts.Name = "flowLayoutPanelPosts";
            this.flowLayoutPanelPosts.Size = new System.Drawing.Size(703, 431);
            this.flowLayoutPanelPosts.TabIndex = 0;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.tabPageAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageAbout.Controls.Add(this.panel2);
            this.tabPageAbout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(713, 441);
            this.tabPageAbout.TabIndex = 1;
            this.tabPageAbout.Text = "About";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanelAbout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 431);
            this.panel2.TabIndex = 0;
            // 
            // tabPageFriends
            // 
            this.tabPageFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.tabPageFriends.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageFriends.Controls.Add(this.flowLayoutPanelFriends);
            this.tabPageFriends.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageFriends.Location = new System.Drawing.Point(4, 22);
            this.tabPageFriends.Name = "tabPageFriends";
            this.tabPageFriends.Size = new System.Drawing.Size(713, 441);
            this.tabPageFriends.TabIndex = 2;
            this.tabPageFriends.Text = "Friends";
            // 
            // flowLayoutPanelFriends
            // 
            this.flowLayoutPanelFriends.AutoScroll = true;
            this.flowLayoutPanelFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFriends.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelFriends.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelFriends.Name = "flowLayoutPanelFriends";
            this.flowLayoutPanelFriends.Size = new System.Drawing.Size(709, 437);
            this.flowLayoutPanelFriends.TabIndex = 1;
            // 
            // tabPagePictures
            // 
            this.tabPagePictures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.tabPagePictures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagePictures.Controls.Add(this.flowLayoutPanelPictures);
            this.tabPagePictures.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPagePictures.Location = new System.Drawing.Point(4, 22);
            this.tabPagePictures.Name = "tabPagePictures";
            this.tabPagePictures.Size = new System.Drawing.Size(713, 441);
            this.tabPagePictures.TabIndex = 3;
            this.tabPagePictures.Text = "Pictures";
            // 
            // flowLayoutPanelPictures
            // 
            this.flowLayoutPanelPictures.AutoScroll = true;
            this.flowLayoutPanelPictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPictures.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelPictures.Name = "flowLayoutPanelPictures";
            this.flowLayoutPanelPictures.Size = new System.Drawing.Size(709, 437);
            this.flowLayoutPanelPictures.TabIndex = 0;
            // 
            // tabPageLikedPages
            // 
            this.tabPageLikedPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.tabPageLikedPages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageLikedPages.Controls.Add(this.flowLayoutLikedPages);
            this.tabPageLikedPages.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageLikedPages.Location = new System.Drawing.Point(4, 22);
            this.tabPageLikedPages.Name = "tabPageLikedPages";
            this.tabPageLikedPages.Size = new System.Drawing.Size(713, 441);
            this.tabPageLikedPages.TabIndex = 4;
            this.tabPageLikedPages.Text = "Liked Pages";
            // 
            // flowLayoutLikedPages
            // 
            this.flowLayoutLikedPages.AutoScroll = true;
            this.flowLayoutLikedPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutLikedPages.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutLikedPages.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutLikedPages.Name = "flowLayoutLikedPages";
            this.flowLayoutLikedPages.Size = new System.Drawing.Size(709, 437);
            this.flowLayoutLikedPages.TabIndex = 2;
            // 
            // tabPageTeams
            // 
            this.tabPageTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.tabPageTeams.Controls.Add(this.flowLayoutPanelTeams);
            this.tabPageTeams.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeams.Name = "tabPageTeams";
            this.tabPageTeams.Size = new System.Drawing.Size(713, 441);
            this.tabPageTeams.TabIndex = 5;
            this.tabPageTeams.Text = "Teams";
            // 
            // flowLayoutPanelTeams
            // 
            this.flowLayoutPanelTeams.AutoScroll = true;
            this.flowLayoutPanelTeams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTeams.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTeams.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelTeams.Name = "flowLayoutPanelTeams";
            this.flowLayoutPanelTeams.Size = new System.Drawing.Size(713, 441);
            this.flowLayoutPanelTeams.TabIndex = 2;
            // 
            // flowLayoutPanelAbout
            // 
            this.flowLayoutPanelAbout.AutoScroll = true;
            this.flowLayoutPanelAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAbout.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelAbout.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelAbout.Name = "flowLayoutPanelAbout";
            this.flowLayoutPanelAbout.Size = new System.Drawing.Size(703, 431);
            this.flowLayoutPanelAbout.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(765, 675);
            this.Controls.Add(this.tabControlFeed);
            this.Controls.Add(this.pictureBoxUserProfile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(779, 668);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            this.tabControlFeed.ResumeLayout(false);
            this.tabPagePosts.ResumeLayout(false);
            this.tabPageAbout.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPageFriends.ResumeLayout(false);
            this.tabPagePictures.ResumeLayout(false);
            this.tabPageLikedPages.ResumeLayout(false);
            this.tabPageTeams.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSendHappyBirthday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCreateNewAlbum;
        private System.Windows.Forms.Button ButtonCreateBusinessCard;
        private System.Windows.Forms.PictureBox pictureBoxUserProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TabControl tabControlFeed;
        private System.Windows.Forms.TabPage tabPagePosts;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.TabPage tabPageFriends;
        private System.Windows.Forms.TabPage tabPagePictures;
        private System.Windows.Forms.TabPage tabPageLikedPages;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPosts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFriends;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPictures;
        private System.Windows.Forms.TabPage tabPageTeams;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutLikedPages;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTeams;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAbout;
    }
}