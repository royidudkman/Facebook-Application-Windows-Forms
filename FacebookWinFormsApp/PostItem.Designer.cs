using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class PostItem
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBoxProfilePicture;
        private Label labelName;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostItem));
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPostText = new System.Windows.Forms.Label();
            this.pictureBoxPostPicture = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(40, 37);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 0;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(56, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(111, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Profile Name";
            // 
            // labelPostText
            // 
            this.labelPostText.AutoEllipsis = true;
            this.labelPostText.AutoSize = true;
            this.labelPostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostText.Location = new System.Drawing.Point(44, 66);
            this.labelPostText.MaximumSize = new System.Drawing.Size(600, 500);
            this.labelPostText.Name = "labelPostText";
            this.labelPostText.Size = new System.Drawing.Size(123, 24);
            this.labelPostText.TabIndex = 2;
            this.labelPostText.Text = "labelPostText";
            // 
            // pictureBoxPostPicture
            // 
            this.pictureBoxPostPicture.Location = new System.Drawing.Point(183, 113);
            this.pictureBoxPostPicture.Name = "pictureBoxPostPicture";
            this.pictureBoxPostPicture.Size = new System.Drawing.Size(325, 254);
            this.pictureBoxPostPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPostPicture.TabIndex = 3;
            this.pictureBoxPostPicture.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(163, 113);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(345, 254);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // PostItem
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pictureBoxPostPicture);
            this.Controls.Add(this.labelPostText);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Name = "PostItem";
            this.Size = new System.Drawing.Size(663, 411);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label labelPostText;
        private PictureBox pictureBoxPostPicture;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
