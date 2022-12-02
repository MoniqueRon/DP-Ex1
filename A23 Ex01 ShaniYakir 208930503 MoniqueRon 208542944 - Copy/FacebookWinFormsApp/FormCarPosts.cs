using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.IO;
using Newtonsoft.Json;



namespace BasicFacebookFeatures
{
    public partial class FormCarPosts : Form
    {
        CarPosts m_CarsPosts = new CarPosts();
        CarPost m_PostCarItem = new CarPost();

        public FormCarPosts(List<CarPost> listOfCarPosts)
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            m_CarsPosts.carPosts = sortPostList(listOfCarPosts);
        }


        private void listPostsByFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            listPostsByFilter_SelectedValueChanged(sender, e);

        }

        private List<CarPost> sortPostList(List<CarPost> lst)
        {
            List<CarPost> SortedList = lst.OrderBy(o => o.PostDate).ToList();
            return SortedList;
        }

        private void GroupsByFilterForm_Load(object sender, EventArgs e)
        {
            listPostsByFilterBox.Items.Clear();
            listPostsByFilterBox.DisplayMember = "Post";
            foreach (CarPost post in m_CarsPosts.carPosts)
            {
                listPostsByFilterBox.Items.Add(post.PostText);
            }
        }

        private void listPostsByFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listPostsByFilterBox.SelectedIndex != -1)
            {
                var itemIndex = listPostsByFilterBox.SelectedIndex;
                m_PostCarItem = m_CarsPosts.getItemByIndex(itemIndex);
                richTextBox2.Text = m_PostCarItem.toString();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}