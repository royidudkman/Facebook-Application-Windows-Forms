using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private BusinessCardScreen BusinessCardScreen { get; set; }
        public MainForm()
        {
            InitializeComponent();
            BusinessCardScreen = new BusinessCardScreen();
        }

        private void ButtonCreateBusinessCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusinessCardScreen.Show();
            
        }
    }
}
