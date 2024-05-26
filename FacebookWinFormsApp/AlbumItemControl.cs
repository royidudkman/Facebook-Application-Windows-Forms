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

        RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        Controls.Add(PictureBox, 0, 0);
        Controls.Add(Label, 0, 1);
    }
}