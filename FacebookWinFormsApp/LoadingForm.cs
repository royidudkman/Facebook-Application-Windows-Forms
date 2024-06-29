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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar_loading.Value < 100)
            {
                progressBar_loading.Value += 1;
                label_precent.Text = progressBar_loading.Value.ToString() + "%";
            }
            else
            {
                timer.Stop();
            }

        }


    }
}
