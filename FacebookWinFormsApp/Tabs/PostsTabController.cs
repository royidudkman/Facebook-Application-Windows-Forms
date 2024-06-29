using BasicFacebookFeatures.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Tabs
{
    public class PostsTabController : BaseTabController
    {
        public event Action PopulateCompleted;

        private PostsController m_PostsController = new PostsController();

        public PostsTabController(FlowLayoutPanel flowLayoutPanel) : base(flowLayoutPanel) { }

        public override void Populate()
        {
            var posts = m_PostsController.FetchPosts();

            foreach (var post in posts)
            {
                FlowLayoutPanel.Controls.Add(post);
            }

            PopulateCompleted?.Invoke();
        }
    }
}