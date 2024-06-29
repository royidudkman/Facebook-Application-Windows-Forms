using System.Drawing;
using System.Windows.Forms;

public class AlbumItemControl : UserControl
{
    private Image m_Image;
    private PictureBox pictureBoxImage;
    private Label labelName;
    private string m_Title;

    public Image Image
    {
        get { return m_Image; }

        set
        {
            m_Image = value;
            pictureBoxImage.Image = m_Image;
        }
    }

    public string Title
    {
        get { return m_Title; }

        set
        {
            m_Title = value;
            labelName.Text = m_Title;
        }
    }

    public AlbumItemControl()
    {
        InitializeComponent();
        //PictureBox = new PictureBox
        //{
        //    Dock = DockStyle.Fill,
        //    SizeMode = PictureBoxSizeMode.StretchImage,

        //};
        //Label = new Label
        //{
        //    Dock = DockStyle.Bottom,
        //    TextAlign = ContentAlignment.MiddleCenter
        //};

        ////RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ////Controls.Add(PictureBox, 0, 0);
        ////Controls.Add(Label, 0, 1);
    }

    private void InitializeComponent()
    {
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(133, 123);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 126);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            // 
            // AlbumItemControl
            // 
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxImage);
            this.Name = "AlbumItemControl";
            this.Size = new System.Drawing.Size(135, 160);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}