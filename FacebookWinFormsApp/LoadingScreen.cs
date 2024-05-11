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

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    progressBar.Value += 5;
        //    labelPrecent.Text = progressBar.Value.ToString() + "%";
        //    if(progressBar.Value == 100)
        //    {
        //        this.Cursor = Cursors.WaitCursor;
        //        //MainForm = new MainForm();
        //        //MainForm.Show();
        //        timer1.Stop();
        //        this.Hide();
        //    }
        //}

        private void UpdateProgressBar(int value)
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke((MethodInvoker)(() => progressBar.Value = value));
            }
            else
            {
                progressBar.Value = value;
            }
        }

        private void UpdateLabel(string text)
        {
            if (labelPrecent.InvokeRequired)
            {
                labelPrecent.Invoke((MethodInvoker)(() => labelPrecent.Text = text));
            }
            else
            {
                labelPrecent.Text = text;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int newValue = progressBar.Value + 5;
            UpdateProgressBar(newValue);
            UpdateLabel(newValue.ToString() + "%");

            if (newValue == 100)
            {
                this.Cursor = Cursors.WaitCursor;
                timer1.Stop();
                this.Hide();
            }
        }



    }
}
