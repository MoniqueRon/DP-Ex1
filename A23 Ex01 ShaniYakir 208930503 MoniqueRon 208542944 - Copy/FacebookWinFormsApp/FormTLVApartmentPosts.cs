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
    public partial class FormTLVApartmentPosts : Form
    {
        TLVApartmentPosts m_TLVPosts = new TLVApartmentPosts();
        TlvApartmentPost m_PostApartmentItem = new TlvApartmentPost();
        public FormTLVApartmentPosts(List<TlvApartmentPost> listTlvApartmentPosts)
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            m_TLVPosts.tlvApartmentPosts = sortPostList(listTlvApartmentPosts);
        }

        private List<TlvApartmentPost> sortPostList(List<TlvApartmentPost> lst)
        {
            List<TlvApartmentPost> SortedList = lst.OrderBy(o => o.PostDate).ToList();
            return SortedList;
        }

        private void tlvListPoststBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            tlvListPostsBox_SelectedValueChanged(sender, e);


        }

        private void TlvPostsForm_Load(object sender, EventArgs e)
        {
            tlvListPoststBox.Items.Clear();
            tlvListPoststBox.DisplayMember = "Post";
            foreach (TlvApartmentPost post in m_TLVPosts.tlvApartmentPosts)
            {
                tlvListPoststBox.Items.Add(post.PostText);
            }
        }

        private void tlvListPostsBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (tlvListPoststBox.SelectedIndex != -1)
            {
                var itemIndex = tlvListPoststBox.SelectedIndex;
                m_PostApartmentItem = m_TLVPosts.getItemByIndex(itemIndex);
                richTextBox1.Text = m_PostApartmentItem.toString();
            }
        }
    }
}
