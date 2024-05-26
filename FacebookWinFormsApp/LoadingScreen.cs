using BasicFacebookFeatures.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class LoadingScreen : Form
    {
        private MainForm MainForm { get; set; }
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            labelPrecent.Text = progressBar.Value.ToString() + "%";
            if (progressBar.Value == 100)
            {
                this.Cursor = Cursors.WaitCursor;
                MainForm = new MainForm();
                MainForm.Show();
                timer1.Stop();
                this.Hide();
            }
        }


    }
}