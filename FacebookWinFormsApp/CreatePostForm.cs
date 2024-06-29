using BasicFacebookFeatures.interfaces;
using BasicFacebookFeatures.Post_Decorators;
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
    public partial class CreatePostForm : Form
    {
        private IPostable m_FinalPost = new PostText();
        
        public CreatePostForm()
        {
            InitializeComponent();
            m_FinalPost.AddDecoratorToPanel(flowLayoutPanel);         
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            m_FinalPost = new ImageDecorator(m_FinalPost);
            m_FinalPost.AddDecoratorToPanel(flowLayoutPanel);
        }

        private void buttonTagFriend_Click(object sender, EventArgs e)
        {
            m_FinalPost = new TagFriendDecorator(m_FinalPost);
            m_FinalPost.AddDecoratorToPanel(flowLayoutPanel);
        }

        private void buttonChangeBackground_Click(object sender, EventArgs e)
        {
            m_FinalPost = new BackgroundDecorator(m_FinalPost);
            m_FinalPost.AddDecoratorToPanel(flowLayoutPanel);
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your post has been uploaded successfully!", "Post Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}