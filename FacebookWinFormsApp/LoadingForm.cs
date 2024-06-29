using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class LoadingForm : Form
    {
        MainForm MainForm;
        private int operationsCompleted = 0;
        private const int totalOperations = 6;


        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            MainForm = new MainForm();
            MainForm.postsTabController.PopulateCompleted += TabController_PopulateCompleted;
            MainForm.friendsTabController.PopulateCompleted += TabController_PopulateCompleted;
            MainForm.aboutTabController.PopulateCompleted += TabController_PopulateCompleted;
            MainForm.picturesTabController.PopulateCompleted += TabController_PopulateCompleted;
            MainForm.LikedPagesTabController.PopulateCompleted += TabController_PopulateCompleted;
            MainForm.TeamsTabController.PopulateCompleted += TabController_PopulateCompleted;
            MainForm.initialData();

        }



        private void TabController_PopulateCompleted()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(TabController_PopulateCompleted));
            }
            else
            {
                operationsCompleted++;
                int progress = (operationsCompleted * 100) / totalOperations;
                progressBar_loading.Value = progress;
                label_precent.Text = progress.ToString() + "%";

                if (operationsCompleted == totalOperations)
                {
                    MainForm.Show();
                    Hide();
                }
            }
        }

    }
}
