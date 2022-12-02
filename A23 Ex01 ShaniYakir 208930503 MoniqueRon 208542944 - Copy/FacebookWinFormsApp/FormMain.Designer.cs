using System;

namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonBestPosts = new System.Windows.Forms.Button();
            this.labelMostLikedPost = new System.Windows.Forms.Label();
            this.textBoxMostLikedPost = new System.Windows.Forms.TextBox();
            this.labelMostCommentedPost = new System.Windows.Forms.Label();
            this.textBoxMostCommentedPost = new System.Windows.Forms.TextBox();
            this.linkAlbums = new System.Windows.Forms.LinkLabel();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.linkEvents = new System.Windows.Forms.LinkLabel();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.linkPages = new System.Windows.Forms.LinkLabel();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.linkGroups = new System.Windows.Forms.LinkLabel();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.pictureBoxGroup = new System.Windows.Forms.PictureBox();
            this.buttonGroupsByFilter = new System.Windows.Forms.Button();
            this.buttonCarRent = new System.Windows.Forms.Button();
            this.buttonTlvAppartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(1100, 12);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(150, 50);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseCompatibleTextRendering = true;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(1100, 82);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(150, 50);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(268, 229);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 53;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(350, 42);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 20);
            this.labelStatus.TabIndex = 72;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(342, 81);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(550, 50);
            this.textBoxStatus.TabIndex = 54;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Enabled = false;
            this.buttonSetStatus.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetStatus.Location = new System.Drawing.Point(898, 81);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(120, 50);
            this.buttonSetStatus.TabIndex = 55;
            this.buttonSetStatus.Text = "Post!";
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // linkPosts
            // 
            this.linkPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkPosts.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPosts.LinkColor = System.Drawing.Color.Black;
            this.linkPosts.Location = new System.Drawing.Point(30, 267);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(250, 69);
            this.linkPosts.TabIndex = 56;
            this.linkPosts.TabStop = true;
            this.linkPosts.Text = "See your posts";
            this.linkPosts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkPosts.UseCompatibleTextRendering = true;
            this.linkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(383, 267);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(221, 364);
            this.listBoxPosts.TabIndex = 40;
            this.listBoxPosts.TabStop = false;
            this.listBoxPosts.Visible = false;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(656, 267);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.ReadOnly = true;
            this.textBoxPost.Size = new System.Drawing.Size(427, 364);
            this.textBoxPost.TabIndex = 41;
            this.textBoxPost.Visible = false;
            // 
            // buttonBestPosts
            // 
            this.buttonBestPosts.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBestPosts.Location = new System.Drawing.Point(383, 191);
            this.buttonBestPosts.Name = "buttonBestPosts";
            this.buttonBestPosts.Size = new System.Drawing.Size(331, 50);
            this.buttonBestPosts.TabIndex = 61;
            this.buttonBestPosts.Text = "Click to see your best posts";
            this.buttonBestPosts.UseCompatibleTextRendering = true;
            this.buttonBestPosts.Visible = false;
            this.buttonBestPosts.Click += new System.EventHandler(this.buttonBestPosts_Click);
            // 
            // labelMostLikedPost
            // 
            this.labelMostLikedPost.AutoSize = true;
            this.labelMostLikedPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMostLikedPost.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostLikedPost.Location = new System.Drawing.Point(383, 267);
            this.labelMostLikedPost.Name = "labelMostLikedPost";
            this.labelMostLikedPost.Size = new System.Drawing.Size(269, 29);
            this.labelMostLikedPost.TabIndex = 62;
            this.labelMostLikedPost.Text = "Your most liked post:";
            this.labelMostLikedPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMostLikedPost.Visible = false;
            // 
            // textBoxMostLikedPost
            // 
            this.textBoxMostLikedPost.Location = new System.Drawing.Point(383, 267);
            this.textBoxMostLikedPost.Multiline = true;
            this.textBoxMostLikedPost.Name = "textBoxMostLikedPost";
            this.textBoxMostLikedPost.ReadOnly = true;
            this.textBoxMostLikedPost.Size = new System.Drawing.Size(700, 200);
            this.textBoxMostLikedPost.TabIndex = 42;
            this.textBoxMostLikedPost.Visible = false;
            // 
            // labelMostCommentedPost
            // 
            this.labelMostCommentedPost.AutoSize = true;
            this.labelMostCommentedPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMostCommentedPost.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostCommentedPost.Location = new System.Drawing.Point(383, 483);
            this.labelMostCommentedPost.Name = "labelMostCommentedPost";
            this.labelMostCommentedPost.Size = new System.Drawing.Size(348, 29);
            this.labelMostCommentedPost.TabIndex = 63;
            this.labelMostCommentedPost.Text = "Your most commented post:";
            this.labelMostCommentedPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMostCommentedPost.Visible = false;
            // 
            // textBoxMostCommentedPost
            // 
            this.textBoxMostCommentedPost.Location = new System.Drawing.Point(383, 483);
            this.textBoxMostCommentedPost.Multiline = true;
            this.textBoxMostCommentedPost.Name = "textBoxMostCommentedPost";
            this.textBoxMostCommentedPost.ReadOnly = true;
            this.textBoxMostCommentedPost.Size = new System.Drawing.Size(700, 200);
            this.textBoxMostCommentedPost.TabIndex = 43;
            this.textBoxMostCommentedPost.Visible = false;
            // 
            // linkAlbums
            // 
            this.linkAlbums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkAlbums.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAlbums.LinkColor = System.Drawing.Color.Black;
            this.linkAlbums.Location = new System.Drawing.Point(30, 354);
            this.linkAlbums.Name = "linkAlbums";
            this.linkAlbums.Size = new System.Drawing.Size(250, 69);
            this.linkAlbums.TabIndex = 57;
            this.linkAlbums.TabStop = true;
            this.linkAlbums.Text = "See your albums";
            this.linkAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkAlbums.UseCompatibleTextRendering = true;
            this.linkAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAlbums_LinkClicked);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.DisplayMember = "name";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 20;
            this.listBoxAlbums.Location = new System.Drawing.Point(383, 267);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(221, 364);
            this.listBoxAlbums.TabIndex = 61;
            this.listBoxAlbums.Visible = false;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.Location = new System.Drawing.Point(656, 267);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(427, 364);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 62;
            this.pictureBoxAlbum.TabStop = false;
            this.pictureBoxAlbum.Visible = false;
            // 
            // linkEvents
            // 
            this.linkEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkEvents.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEvents.LinkColor = System.Drawing.Color.Black;
            this.linkEvents.Location = new System.Drawing.Point(30, 442);
            this.linkEvents.Name = "linkEvents";
            this.linkEvents.Size = new System.Drawing.Size(250, 69);
            this.linkEvents.TabIndex = 58;
            this.linkEvents.TabStop = true;
            this.linkEvents.Text = "See your events";
            this.linkEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkEvents.UseCompatibleTextRendering = true;
            this.linkEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEvents_LinkClicked);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(383, 267);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(221, 364);
            this.listBoxEvents.TabIndex = 63;
            this.listBoxEvents.Visible = false;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Location = new System.Drawing.Point(656, 267);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(427, 364);
            this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEvent.TabIndex = 64;
            this.pictureBoxEvent.TabStop = false;
            this.pictureBoxEvent.Visible = false;
            // 
            // linkPages
            // 
            this.linkPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkPages.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPages.LinkColor = System.Drawing.Color.Black;
            this.linkPages.Location = new System.Drawing.Point(30, 529);
            this.linkPages.Name = "linkPages";
            this.linkPages.Size = new System.Drawing.Size(250, 69);
            this.linkPages.TabIndex = 59;
            this.linkPages.TabStop = true;
            this.linkPages.Text = "See your Pages";
            this.linkPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkPages.UseCompatibleTextRendering = true;
            this.linkPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPages_LinkClicked);
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 20;
            this.listBoxPages.Location = new System.Drawing.Point(383, 267);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(221, 364);
            this.listBoxPages.TabIndex = 65;
            this.listBoxPages.Visible = false;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.Location = new System.Drawing.Point(656, 267);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(427, 364);
            this.pictureBoxPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPage.TabIndex = 66;
            this.pictureBoxPage.TabStop = false;
            this.pictureBoxPage.Visible = false;
            // 
            // linkGroups
            // 
            this.linkGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkGroups.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGroups.LinkColor = System.Drawing.Color.Black;
            this.linkGroups.Location = new System.Drawing.Point(30, 614);
            this.linkGroups.Name = "linkGroups";
            this.linkGroups.Size = new System.Drawing.Size(250, 69);
            this.linkGroups.TabIndex = 60;
            this.linkGroups.TabStop = true;
            this.linkGroups.Text = "See your groups";
            this.linkGroups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkGroups.UseCompatibleTextRendering = true;
            this.linkGroups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGroups_LinkClicked);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 20;
            this.listBoxGroups.Location = new System.Drawing.Point(383, 267);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(221, 364);
            this.listBoxGroups.TabIndex = 67;
            this.listBoxGroups.Visible = false;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // pictureBoxGroup
            // 
            this.pictureBoxGroup.Location = new System.Drawing.Point(656, 267);
            this.pictureBoxGroup.Name = "pictureBoxGroup";
            this.pictureBoxGroup.Size = new System.Drawing.Size(427, 364);
            this.pictureBoxGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGroup.TabIndex = 68;
            this.pictureBoxGroup.TabStop = false;
            this.pictureBoxGroup.Visible = false;
            // 
            // buttonGroupsByFilter
            // 
            this.buttonGroupsByFilter.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGroupsByFilter.Location = new System.Drawing.Point(383, 191);
            this.buttonGroupsByFilter.Name = "buttonGroupsByFilter";
            this.buttonGroupsByFilter.Size = new System.Drawing.Size(331, 50);
            this.buttonGroupsByFilter.TabIndex = 69;
            this.buttonGroupsByFilter.Text = "Click to filter your groups";
            this.buttonGroupsByFilter.UseCompatibleTextRendering = true;
            this.buttonGroupsByFilter.Visible = false;
            this.buttonGroupsByFilter.Click += new System.EventHandler(this.buttonGroupsByFilter_Click);
            // 
            // buttonCarRent
            // 
            this.buttonCarRent.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCarRent.Location = new System.Drawing.Point(702, 353);
            this.buttonCarRent.Name = "buttonCarRent";
            this.buttonCarRent.Size = new System.Drawing.Size(190, 158);
            this.buttonCarRent.TabIndex = 71;
            this.buttonCarRent.Text = "Cars for rent";
            this.buttonCarRent.UseCompatibleTextRendering = true;
            this.buttonCarRent.Visible = false;
            this.buttonCarRent.Click += new System.EventHandler(this.buttonCarRent_Click);
            // 
            // buttonTlvAppartment
            // 
            this.buttonTlvAppartment.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTlvAppartment.Location = new System.Drawing.Point(383, 354);
            this.buttonTlvAppartment.Name = "buttonTlvAppartment";
            this.buttonTlvAppartment.Size = new System.Drawing.Size(190, 158);
            this.buttonTlvAppartment.TabIndex = 70;
            this.buttonTlvAppartment.Text = "TLV apartments for rent";
            this.buttonTlvAppartment.UseCompatibleTextRendering = true;
            this.buttonTlvAppartment.Visible = false;
            this.buttonTlvAppartment.Click += new System.EventHandler(this.buttonTlvAppartment_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 727);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.linkPosts);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.buttonBestPosts);
            this.Controls.Add(this.labelMostLikedPost);
            this.Controls.Add(this.textBoxMostLikedPost);
            this.Controls.Add(this.labelMostCommentedPost);
            this.Controls.Add(this.textBoxMostCommentedPost);
            this.Controls.Add(this.linkAlbums);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Controls.Add(this.linkEvents);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.linkPages);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.pictureBoxPage);
            this.Controls.Add(this.linkGroups);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.pictureBoxGroup);
            this.Controls.Add(this.buttonGroupsByFilter);
            this.Controls.Add(this.buttonTlvAppartment);
            this.Controls.Add(this.buttonCarRent);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// Login/out
        private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxProfile;

        /// Posts
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonBestPosts;
        private System.Windows.Forms.Label labelMostLikedPost;
        private System.Windows.Forms.TextBox textBoxMostLikedPost;
        private System.Windows.Forms.Label labelMostCommentedPost;
        private System.Windows.Forms.TextBox textBoxMostCommentedPost;

        /// Albums
        private System.Windows.Forms.LinkLabel linkAlbums;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.ListBox listBoxAlbums;

        /// Events
        private System.Windows.Forms.LinkLabel linkEvents;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.ListBox listBoxEvents;

        /// Pages
        private System.Windows.Forms.LinkLabel linkPages;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.ListBox listBoxPages;

        /// Groups
        private System.Windows.Forms.LinkLabel linkGroups;
        private System.Windows.Forms.PictureBox pictureBoxGroup;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonGroupsByFilter;
        private System.Windows.Forms.Button buttonCarRent;
        private System.Windows.Forms.Button buttonTlvAppartment;
        
    }
}

