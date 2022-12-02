using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.IO;
using Newtonsoft.Json;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private string get_Relative_Path(string rel_path)
        {
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, rel_path);
            string icon_path = Path.GetFullPath(file);
            icon_path = icon_path.Replace(@"\\", @"\");

            return icon_path;
        }

        User m_LoggedInUser;
        LoginResult m_LoginResult;
        CarPosts m_UserCarGroupPosts = new CarPosts();
        TLVApartmentPosts m_TLVApartmentPosts = new TLVApartmentPosts();

        string carsJsonpath = @"..\\JsonFakeGroupsPosts\\carRental.json";
        string TlvApartmentJsonPath = @"..\\JsonFakeGroupsPosts\\TLVapartmentRental.json";


        /// Login
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter
            loginAndInit();
            
        }

        private void loginAndInit()
        {
            m_LoginResult = FacebookService.Login(
                    "446018321062802",
                    /// requested permissions:
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;

                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            labelStatus.Text = $"What's on your mind, {m_LoginResult.LoggedInUser.FirstName}?";
        }

        /// Logout
        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
            m_LoginResult = null;
        }

        /// Posts

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {
            buttonSetStatus.Enabled = true;
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = m_LoggedInUser.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Posted! ID: " + postedStatus.Id);
            }
            catch
            {
                MessageBox.Show("Please try again");
            }
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideAllBoxes();
            fetchPosts();
            listBoxPosts.Visible = true;
            textBoxPost.Visible = true;
            buttonBestPosts.Visible = true;
        }

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                hideAllBoxes();
                MessageBox.Show("No Posts to show :(");
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPost();
        }

        private void displaySelectedPost()
        {
            if (listBoxPosts.SelectedItems.Count == 1)
            {
                textBoxPost.Text = listBoxPosts.SelectedItem.ToString();
            }
        }

        private void buttonBestPosts_Click(object sender, EventArgs e)
        {
            hideAllBoxes();
            fetchBestPosts();
            labelMostLikedPost.Visible = true;
            textBoxMostLikedPost.Visible = true;
            labelMostCommentedPost.Visible = true;
            textBoxMostCommentedPost.Visible = true;
        }

        private void fetchBestPosts()
        {
            fetchMostLikedPost();
            fetchMostCommentedPost();
        }

        private void fetchMostLikedPost()
        {
            int maxLikes = 0;
            Post postWithMaxLikes = new Post();
            try
            {
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    if (post.LikedBy.Count() > maxLikes)
                    {
                        maxLikes = post.LikedBy.Count();
                        postWithMaxLikes = post;
                    }

                    if (postWithMaxLikes.Message != null)
                    {
                        textBoxMostLikedPost.Text = postWithMaxLikes.Message;
                    }
                    else if (postWithMaxLikes.Caption != null)
                    {
                        textBoxMostLikedPost.Text = postWithMaxLikes.Caption;
                    }
                    else
                    {
                        textBoxMostLikedPost.Text = string.Format("[{0}]", postWithMaxLikes.Type);
                    }
                }
            }
            catch
            {
                MessageBox.Show("No permission to see post likes.. ):");
            }
        }

        private void fetchMostCommentedPost()
        {
            int maxComments = 0;
            Post postWithMaxComments = null;
            try
            {
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    if (post.Comments.Count() > maxComments)
                    {
                        maxComments = post.Comments.Count();
                        postWithMaxComments = post;
                    }
                }

                if (postWithMaxComments.Message != null)
                {
                    textBoxMostCommentedPost.Text = postWithMaxComments.Message;
                }
            }
            catch
            {
                MessageBox.Show("No permission to see post comments.. ):");
            }
        }

        /// Albums
        private void linkAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideAllBoxes();
            fetchAlbums();
            listBoxAlbums.Visible = true;
            pictureBoxAlbum.Visible = true;
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";
            foreach (Album album in m_LoggedInUser.Albums)
            {
                listBoxAlbums.Items.Add(album);
                //album.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                hideAllBoxes();
                MessageBox.Show("No Albums to show :(");
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    pictureBoxAlbum.Image = pictureBoxAlbum.ErrorImage;
                }
            }
        }

        /// Events
        private void linkEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideAllBoxes();
            fetchEvents();
            listBoxEvents.Visible = true;
            pictureBoxEvent.Visible = true;
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (listBoxEvents.Items.Count == 0)
            {
                hideAllBoxes();
                MessageBox.Show("No Events to show :(");
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedEvent();
        }

        private void displaySelectedEvent()
        {
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
                if (selectedEvent.PictureNormalURL != null)
                {
                    pictureBoxEvent.LoadAsync(selectedEvent.PictureNormalURL);
                }
                else
                {
                    pictureBoxEvent.Image = pictureBoxEvent.ErrorImage;
                }
            }
        }

        /// Pages
        private void linkPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideAllBoxes();
            fetchLikedPages();
            listBoxPages.Visible = true;
            pictureBoxPage.Visible = true;
        }

        private void fetchLikedPages()
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = "Name";

            try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxPages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxPages.Items.Count == 0)
            {
                hideAllBoxes();
                MessageBox.Show("No liked pages to show :(");
            }
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPage();
        }

        private void displaySelectedPage()
        {
            if (listBoxPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxPages.SelectedItem as Page;
                if (selectedPage.PictureNormalURL != null)
                {
                    pictureBoxPage.LoadAsync(selectedPage.PictureNormalURL);
                }
                else
                {
                    pictureBoxPage.Image = pictureBoxPage.ErrorImage;
                }
            }
        }

        /// Groups
        private void linkGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hideAllBoxes();
            fetchGroups();
            listBoxGroups.Visible = true;
            pictureBoxGroup.Visible = true;
            buttonGroupsByFilter.Visible = true;
        }

        private void fetchGroups()
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";

            try
            {
                foreach (Group group in m_LoggedInUser.Groups)
                {
                    listBoxGroups.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                hideAllBoxes();
                MessageBox.Show("No groups to show :(");
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedGroup();
        }

        private void displaySelectedGroup()
        {
            if (listBoxGroups.SelectedItems.Count == 1)
            {
                Group selectedGroup = listBoxGroups.SelectedItem as Group;
                if (selectedGroup.PictureNormalURL != null)
                {
                    pictureBoxGroup.LoadAsync(selectedGroup.PictureNormalURL);
                }
                else
                {
                    pictureBoxGroup.Image = pictureBoxGroup.ErrorImage;
                }
            }
        }

        private void buttonGroupsByFilter_Click(object sender, EventArgs e)
        {
            hideAllBoxes();
            buttonTlvAppartment.Visible = true;
            buttonCarRent.Visible = true;
        }

        private void buttonCarRent_Click(object sender, EventArgs e)
        {
            var carPathRelative = get_Relative_Path(carsJsonpath);

            try
            {
                m_UserCarGroupPosts = new CarPosts();
                m_UserCarGroupPosts.carPosts = new List<CarPost>();

                CarPosts jsonCarData = JsonConvert.DeserializeObject<CarPosts>(File.ReadAllText(carPathRelative));

                if (jsonCarData != null)
                {
                    foreach (CarPost carPost in jsonCarData.carPosts)
                    {
                        if (m_UserCarGroupPosts.carPosts.Contains(carPost) == false)
                        {
                            m_UserCarGroupPosts.carPosts.Add(carPost);
                        }

                    }
                }
                viewAllCarGroupPostsSortedByDate();
            }
            catch
            {
                MessageBox.Show("It didnt work out. Please try again");
            }

/*  No permissions for group posts, the following code assumes there are.
           
            try
            {
                if (m_LoggedInUser.Groups.Count > 0)
                {
                    m_UserCarGroupPosts = new CarPosts();
                    CarPost carPost;
                    var id = 0;
                    StreamWriter sw = File.AppendText(get_Relative_Path(carPathRelative));

                    foreach (Group group in m_LoggedInUser.Groups)
                    {
                        if (group.Name.Contains("Cars Rent") || group.Name.Contains("Cars for buy") || group.Name.Contains("Rent Car Group"))
                        {
                            carPost = new CarPost();
                            foreach (Post post in group.WallPosts)
                            {
                                carPost.Id = id++;
                                carPost.UserName = post.Name;
                                carPost.PostText = post.Message;
                                carPost.NameOfGroup = group.Name;
                                carPost.PostDate = post.CreatedTime.ToString();

                                string jsonString = JsonConvert.SerializeObject(carPost, Formatting.Indented);
                                sw.WriteLine(jsonString);
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }

                    viewAllCarGroupPostsSortedByDate();
                }

                else
                {
                    *//*MessageBox.Show("You have no groups:(");*//*
                    
                }
            }
            catch
            {
                MessageBox.Show("You need to sign up first!");
            }*/
        }

        private void buttonTlvAppartment_Click(object sender, EventArgs e)
        {
            var tlvPathRelative = get_Relative_Path(TlvApartmentJsonPath);
            try
            {
                m_TLVApartmentPosts = new TLVApartmentPosts();
                m_TLVApartmentPosts.tlvApartmentPosts = new List<TlvApartmentPost>();

                TLVApartmentPosts jsonTlvData = JsonConvert.DeserializeObject<TLVApartmentPosts>(File.ReadAllText(tlvPathRelative));

                if (jsonTlvData != null)
                {
                    foreach (TlvApartmentPost tlvPost in jsonTlvData.tlvApartmentPosts)
                    {
                        if (m_TLVApartmentPosts.tlvApartmentPosts.Contains(tlvPost) == false)
                        {
                            m_TLVApartmentPosts.tlvApartmentPosts.Add(tlvPost);
                        }

                    }
                }
                viewAllTLVApartmentsGroupPostsSortedByDate();
            }
            catch
            {
                MessageBox.Show("It didnt work out. Please try again");
            }


            /*No permissions for group posts, the following code assumes there are.
             * try
            {
                if (m_LoggedInUser.Groups.Count > 0)
                {
                    TlvApartmentPost tlvApaPost;
                    var id = 0;
                    StreamWriter sw = File.AppendText(tlvPathRelative);

                    foreach (Group group in m_LoggedInUser.Groups)
                    {
                        if (group.Name.Contains("TLV Apartments For rent") || group.Name.Contains("Tel Aviv Apartment") || group.Name.Contains("Rent in Tel-Aviv"))
                        {
                            tlvApaPost = new TlvApartmentPost();
                            foreach (Post post in group.WallPosts)
                            {
                                tlvApaPost.Id = id++;
                                tlvApaPost.UserName = post.Name;
                                tlvApaPost.PostText = post.Message;
                                tlvApaPost.NameOfGroup = group.Name;
                                tlvApaPost.PostDate = post.CreatedTime.ToString();

                                string jsonString = JsonConvert.SerializeObject(tlvApaPost, Formatting.Indented);
                                sw.WriteLine(jsonString);
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }

                    creatNewJoinCommentsByDateWithTlvApartmentKeyGroup();
                }


                else
                {
                    *//*MessageBox.Show("You have no groups:(");*//*
                }
            }
            catch
            {
                MessageBox.Show("You need to sign up first");
            }*/
        }


        private void viewAllCarGroupPostsSortedByDate()
        {
            FormCarPosts f2 = new FormCarPosts(m_UserCarGroupPosts.carPosts);
            f2.ShowDialog();

        }

        private void viewAllTLVApartmentsGroupPostsSortedByDate()
        {
            FormTLVApartmentPosts f2 = new FormTLVApartmentPosts(m_TLVApartmentPosts.tlvApartmentPosts);
            f2.ShowDialog();
        }

        private void hideAllBoxes()
        {
            // Posts
            listBoxPosts.Visible = false;
            textBoxPost.Visible = false;
            buttonBestPosts.Visible = false;
            labelMostLikedPost.Visible = false;
            textBoxMostLikedPost.Visible = false;
            labelMostCommentedPost.Visible = false;
            textBoxMostCommentedPost.Visible = false;
            // Albums
            listBoxAlbums.Visible = false;
            pictureBoxAlbum.Visible = false;
            // Events
            listBoxEvents.Visible = false;
            pictureBoxEvent.Visible = false;
            // Pages
            listBoxPages.Visible = false;
            pictureBoxPage.Visible = false;
            // Groups
            listBoxGroups.Visible = false;
            pictureBoxGroup.Visible = false;
            buttonGroupsByFilter.Visible = false;
            buttonTlvAppartment.Visible = false;
            buttonCarRent.Visible = false;
        }
    }
}
