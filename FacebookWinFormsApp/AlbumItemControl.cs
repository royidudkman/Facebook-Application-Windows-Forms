using System.Drawing;
using System.Windows.Forms;

public class AlbumItemControl : TableLayoutPanel
{
    public PictureBox PictureBox { get; private set; }
    public Label Label { get; private set; }

    public AlbumItemControl()
    {
        PictureBox = new PictureBox
        {
            Dock = DockStyle.Fill,
            SizeMode = PictureBoxSizeMode.StretchImage,
             
        };

        Label = new Label
        {
            Dock = DockStyle.Bottom,
            TextAlign = ContentAlignment.MiddleCenter
        };

        this.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.Controls.Add(PictureBox, 0, 0);
        this.Controls.Add(Label, 0, 1);
    }
}
