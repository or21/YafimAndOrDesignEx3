﻿//-----------------------------------------------------------------------
// <copyright file="FormMainWindow.Designer.cs" company="A16_Ex02">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------
namespace AppUI
{
    /// <summary>
    /// Form designer
    /// </summary>
    public partial class FormMainWindow
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxCheckIn = new System.Windows.Forms.ListBox();
            this.listBoxProfie = new System.Windows.Forms.ListBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.buttonGetMostPhotos = new Utils.ButtonFbBlue();
            this.buttonGetCelebsBD = new Utils.ButtonFbBlue();
            this.buttonPost = new Utils.ButtonFbBlue();
            this.buttonLogout = new Utils.ButtonFbWhite();
            this.listBoxFeed = new System.Windows.Forms.ListBox();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelCheckIn = new System.Windows.Forms.Label();
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelPages = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelFeed = new System.Windows.Forms.Label();
            this.displayPostTextBox = new System.Windows.Forms.TextBox();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.labePostToFB = new System.Windows.Forms.Label();
            this.labelUpdateLocalFeed = new System.Windows.Forms.Label();
            this.buttonFbBlueMostComments = new Utils.ButtonFbBlue();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(49, 39);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(120, 83);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(31, 147);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(154, 121);
            this.listBoxEvents.TabIndex = 3;
            // 
            // listBoxCheckIn
            // 
            this.listBoxCheckIn.FormattingEnabled = true;
            this.listBoxCheckIn.Location = new System.Drawing.Point(31, 303);
            this.listBoxCheckIn.Name = "listBoxCheckIn";
            this.listBoxCheckIn.Size = new System.Drawing.Size(154, 121);
            this.listBoxCheckIn.TabIndex = 4;
            // 
            // listBoxProfie
            // 
            this.listBoxProfie.FormattingEnabled = true;
            this.listBoxProfie.Location = new System.Drawing.Point(585, 147);
            this.listBoxProfie.Name = "listBoxProfie";
            this.listBoxProfie.Size = new System.Drawing.Size(154, 121);
            this.listBoxProfie.TabIndex = 6;
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(585, 303);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(154, 121);
            this.listBoxPages.TabIndex = 7;
            // 
            // buttonGetMostPhotos
            // 
            this.buttonGetMostPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.buttonGetMostPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetMostPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonGetMostPhotos.ForeColor = System.Drawing.Color.White;
            this.buttonGetMostPhotos.Location = new System.Drawing.Point(31, 446);
            this.buttonGetMostPhotos.Name = "buttonGetMostPhotos";
            this.buttonGetMostPhotos.Size = new System.Drawing.Size(204, 23);
            this.buttonGetMostPhotos.TabIndex = 9;
            this.buttonGetMostPhotos.Text = "Get 5 Most Likeable Photos";
            this.buttonGetMostPhotos.UseVisualStyleBackColor = false;
            this.buttonGetMostPhotos.Click += new System.EventHandler(this.buttonTopLikeablePhotos_Click);
            // 
            // buttonGetCelebsBD
            // 
            this.buttonGetCelebsBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.buttonGetCelebsBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetCelebsBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonGetCelebsBD.ForeColor = System.Drawing.Color.White;
            this.buttonGetCelebsBD.Location = new System.Drawing.Point(536, 446);
            this.buttonGetCelebsBD.Name = "buttonGetCelebsBD";
            this.buttonGetCelebsBD.Size = new System.Drawing.Size(203, 23);
            this.buttonGetCelebsBD.TabIndex = 10;
            this.buttonGetCelebsBD.Text = "WhoWasBornOnMyBirthday was born on my Birthday";
            this.buttonGetCelebsBD.UseVisualStyleBackColor = false;
            this.buttonGetCelebsBD.Click += new System.EventHandler(this.buttonGetCelebsBD_Click);
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.ForeColor = System.Drawing.Color.White;
            this.buttonPost.Location = new System.Drawing.Point(544, 48);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 12;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Black;
            this.buttonLogout.Location = new System.Drawing.Point(664, 48);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 13;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // listBoxFeed
            // 
            this.listBoxFeed.DataSource = this.postsBindingSource;
            this.listBoxFeed.DisplayMember = "DisplayMessage";
            this.listBoxFeed.FormattingEnabled = true;
            this.listBoxFeed.Location = new System.Drawing.Point(209, 147);
            this.listBoxFeed.Name = "listBoxFeed";
            this.listBoxFeed.Size = new System.Drawing.Size(347, 277);
            this.listBoxFeed.TabIndex = 2;
            this.listBoxFeed.ValueMember = "Caption";
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataSource = typeof(Utils.MyPost);
            // 
            // labelCheckIn
            // 
            this.labelCheckIn.AutoSize = true;
            this.labelCheckIn.Location = new System.Drawing.Point(80, 287);
            this.labelCheckIn.Name = "labelCheckIn";
            this.labelCheckIn.Size = new System.Drawing.Size(50, 13);
            this.labelCheckIn.TabIndex = 14;
            this.labelCheckIn.Text = "Check In";
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Location = new System.Drawing.Point(84, 131);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(40, 13);
            this.labelEvents.TabIndex = 15;
            this.labelEvents.Text = "Events";
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(644, 287);
            this.labelPages.Name = "labelPages";
            this.labelPages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPages.Size = new System.Drawing.Size(37, 13);
            this.labelPages.TabIndex = 16;
            this.labelPages.Text = "Pages";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(632, 131);
            this.labelData.Name = "labelData";
            this.labelData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelData.Size = new System.Drawing.Size(60, 13);
            this.labelData.TabIndex = 17;
            this.labelData.Text = "Profile data";
            // 
            // labelFeed
            // 
            this.labelFeed.AutoSize = true;
            this.labelFeed.Location = new System.Drawing.Point(354, 131);
            this.labelFeed.Name = "labelFeed";
            this.labelFeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFeed.Size = new System.Drawing.Size(58, 13);
            this.labelFeed.TabIndex = 18;
            this.labelFeed.Text = "News feed";
            // 
            // displayPostTextBox
            // 
            this.displayPostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postsBindingSource, "DisplayMessage", true));
            this.displayPostTextBox.Location = new System.Drawing.Point(283, 84);
            this.displayPostTextBox.Name = "displayPostTextBox";
            this.displayPostTextBox.Size = new System.Drawing.Size(240, 20);
            this.displayPostTextBox.TabIndex = 20;
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(283, 48);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(240, 20);
            this.postTextBox.TabIndex = 21;
            this.postTextBox.Click += new System.EventHandler(this.postTextBox_Click);
            // 
            // labePostToFB
            // 
            this.labePostToFB.AutoSize = true;
            this.labePostToFB.Location = new System.Drawing.Point(179, 51);
            this.labePostToFB.Name = "labePostToFB";
            this.labePostToFB.Size = new System.Drawing.Size(56, 13);
            this.labePostToFB.TabIndex = 22;
            this.labePostToFB.Text = "Post to FB";
            // 
            // labelUpdateLocalFeed
            // 
            this.labelUpdateLocalFeed.AutoSize = true;
            this.labelUpdateLocalFeed.Location = new System.Drawing.Point(179, 87);
            this.labelUpdateLocalFeed.Name = "labelUpdateLocalFeed";
            this.labelUpdateLocalFeed.Size = new System.Drawing.Size(98, 13);
            this.labelUpdateLocalFeed.TabIndex = 23;
            this.labelUpdateLocalFeed.Text = "Update Local Feed";
            // 
            // buttonFbBlueMostComments
            // 
            this.buttonFbBlueMostComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.buttonFbBlueMostComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFbBlueMostComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFbBlueMostComments.ForeColor = System.Drawing.Color.White;
            this.buttonFbBlueMostComments.Location = new System.Drawing.Point(241, 446);
            this.buttonFbBlueMostComments.Name = "buttonFbBlueMostComments";
            this.buttonFbBlueMostComments.Size = new System.Drawing.Size(207, 23);
            this.buttonFbBlueMostComments.TabIndex = 24;
            this.buttonFbBlueMostComments.Text = "Get 5 Most Commentated Photos";
            this.buttonFbBlueMostComments.UseVisualStyleBackColor = false;
            this.buttonFbBlueMostComments.Click += new System.EventHandler(this.buttonFbBlueMostComments_Click);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 490);
            this.Controls.Add(this.buttonFbBlueMostComments);
            this.Controls.Add(this.labelUpdateLocalFeed);
            this.Controls.Add(this.labePostToFB);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.displayPostTextBox);
            this.Controls.Add(this.labelFeed);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.labelCheckIn);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.buttonGetCelebsBD);
            this.Controls.Add(this.buttonGetMostPhotos);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.listBoxProfie);
            this.Controls.Add(this.listBoxCheckIn);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxFeed);
            this.Controls.Add(this.pictureBoxProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainWindow";
            this.Text = "FaceBoo";
            this.Controls.SetChildIndex(this.pictureBoxProfile, 0);
            this.Controls.SetChildIndex(this.listBoxFeed, 0);
            this.Controls.SetChildIndex(this.listBoxEvents, 0);
            this.Controls.SetChildIndex(this.listBoxCheckIn, 0);
            this.Controls.SetChildIndex(this.listBoxProfie, 0);
            this.Controls.SetChildIndex(this.listBoxPages, 0);
            this.Controls.SetChildIndex(this.buttonGetMostPhotos, 0);
            this.Controls.SetChildIndex(this.buttonGetCelebsBD, 0);
            this.Controls.SetChildIndex(this.buttonPost, 0);
            this.Controls.SetChildIndex(this.buttonLogout, 0);
            this.Controls.SetChildIndex(this.labelCheckIn, 0);
            this.Controls.SetChildIndex(this.labelEvents, 0);
            this.Controls.SetChildIndex(this.labelPages, 0);
            this.Controls.SetChildIndex(this.labelData, 0);
            this.Controls.SetChildIndex(this.labelFeed, 0);
            this.Controls.SetChildIndex(this.displayPostTextBox, 0);
            this.Controls.SetChildIndex(this.postTextBox, 0);
            this.Controls.SetChildIndex(this.labePostToFB, 0);
            this.Controls.SetChildIndex(this.labelUpdateLocalFeed, 0);
            this.Controls.SetChildIndex(this.buttonFbBlueMostComments, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxCheckIn;
        private System.Windows.Forms.ListBox listBoxProfie;
        private System.Windows.Forms.ListBox listBoxPages;
        private Utils.ButtonFbBlue buttonGetMostPhotos;
        private Utils.ButtonFbBlue buttonGetCelebsBD;
        private Utils.ButtonFbBlue buttonPost;
        private Utils.ButtonFbWhite buttonLogout;
        private System.Windows.Forms.ListBox listBoxFeed;
        private System.Windows.Forms.Label labelCheckIn;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelFeed;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private System.Windows.Forms.TextBox displayPostTextBox;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Label labePostToFB;
        private System.Windows.Forms.Label labelUpdateLocalFeed;
        private Utils.ButtonFbBlue buttonFbBlueMostComments;
    }
}
