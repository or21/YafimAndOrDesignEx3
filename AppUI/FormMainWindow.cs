﻿//-----------------------------------------------------------------------
// <copyright file="FormMainWindow.cs" company="A16_Ex03">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Utils;

namespace AppUI
{
    /// <summary>
    /// UI of the application.
    /// </summary>
    public partial class FormMainWindow : FormFb
    {
        /// <summary>
        /// Post message.
        /// </summary>
        private const string k_StartPost = "What's on your mind...";

        /// <summary>
        /// Events message
        /// </summary>
        private const string k_NoEventYet = "No Events yet";

        /// <summary>
        /// No likes message
        /// </summary>
        private const string k_NoLikes = "You don't like any page";

        /// <summary>
        /// No checkIn message
        /// </summary>
        private const string k_NoCheckIns = "You didn't do any check in";

        /// <summary>
        /// Wait message
        /// </summary>
        private const string k_WaitMessage = "This may take few seconds... Please click OK and Go get yourself a cup of coffee";

        /// <summary>
        /// List of facebook photos
        /// </summary>
        private static List<Photo> s_ListOfPhotos;

        /// <summary>
        /// User birthday
        /// </summary>
        private static string s_Bdate;

        /// <summary>
        /// FeatureReceiver instance
        /// </summary>
        private readonly FeatureReceiver r_FeatureReceiver;

        /// <summary>
        /// LoggedIn user
        /// </summary>
        private readonly User r_LoggedInUser;

        /// <summary>
        /// Feature builder
        /// </summary>
        private readonly FeatureBuilder r_FeaturesFactory = new FeatureBuilder(Assembly.GetExecutingAssembly());

        /// <summary>
        /// List of threads
        /// </summary>
        private readonly List<Thread> r_Threads = new List<Thread>();

        /// <summary>
        /// My posts on facebook
        /// </summary>
        private List<MyPost> m_MyPosts; 

        /// <summary>
        /// Initializes a new instance of the FormMainWindow class.
        /// </summary>
        /// <param name="i_UserData">The user facebook data</param>
        public FormMainWindow(LoginResult i_UserData)
        {
            InitializeComponent();
            r_LoggedInUser = i_UserData.LoggedInUser;
            m_MyPosts = new List<MyPost>();
            loadPosts();
            FacebookService.s_CollectionLimit = 1000;
            s_Bdate = r_LoggedInUser.Birthday;

            r_FeatureReceiver = new FeatureReceiver(r_FeaturesFactory);

            setCommandsInUi();
        }

        /// <summary>
        /// Initialize commands
        /// </summary>
        private void setCommandsInUi()
        {
            r_FeatureReceiver.WhoWasBornOnMyBirthdayCommand(typeof(FormWhoWasBornOnMyBirthday));
            r_FeatureReceiver.MostLikeablePhotosCommand(typeof(FormComparedPhotos), new GetMostLikeablePhotos());
            r_FeatureReceiver.MostCommentatedPhotosCommand(typeof(FormComparedPhotos), new GetMostCommentatedPhotos());
        }

        /// <summary>
        /// Load facebook posts
        /// </summary>
        private void loadPosts()
        {
            foreach (Post post in r_LoggedInUser.Posts)
            {
                m_MyPosts.Add(new MyPost(post));
            }
        }

        /// <summary>
        /// Loads the user info on different thread
        /// </summary>
        /// <param name="i_Event">the event</param>
        protected override void OnLoad(EventArgs i_Event) 
        {
            base.OnLoad(i_Event);
            new Thread(fetchUserInfo).Start();
        }

        /// <summary>
        /// Clear textBox when clicked
        /// </summary>
        /// <param name="i_Sender">Object sender</param>
        /// <param name="i_Event">The event</param>
        private void postTextBox_Click(object i_Sender, EventArgs i_Event)
        {
            postTextBox.Clear();
            postTextBox.ForeColor = Color.Black;
        }

        /// <summary>
        /// Fetch events and show them in relevant textbox
        /// </summary>
        private void fetchEvents()
        {
            listBoxEvents.Invoke(new Action(() => listBoxEvents.HorizontalScrollbar = true));
            listBoxEvents.Invoke(new Action(() => listBoxEvents.DisplayMember = "Name"));
            foreach (Event fbEvent in r_LoggedInUser.Events)
            {
                listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(fbEvent)));
            }

            if (r_LoggedInUser.Events.Count == 0)
            {
                listBoxEvents.Invoke(new Action(() => listBoxEvents.BackColor = Color.Gray));
                listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(k_NoEventYet)));
            }
        }

        /// <summary>
        /// Fetch user information and show them in relevant textbox
        /// </summary>
        private void fetchUserInfo()
        {
            Thread threadPhotos = new Thread(fetchPhotos);
            r_Threads.Add(threadPhotos);
            threadPhotos.Start();

            postTextBox.Invoke(new Action(() => postTextBox.Text = k_StartPost));
            new Thread(fetchEvents).Start();
            new Thread(fetchUserData).Start();
            new Thread(fetchNewsFeed).Start();
            new Thread(fetchPages).Start();
            new Thread(fetchCheckIn).Start();
        }

        /// <summary>
        /// Fetch pages and show them in relevant textbox
        /// </summary>
        private void fetchPages()
        {
            listBoxPages.Invoke(new Action(() => listBoxPages.HorizontalScrollbar = true));
            listBoxPages.Invoke(new Action(() => listBoxPages.DisplayMember = "Name"));
            foreach (Page fbPage in r_LoggedInUser.LikedPages)
            {
                listBoxPages.Invoke(new Action(() => listBoxPages.Items.Add(fbPage)));
            }

            if (r_LoggedInUser.LikedPages.Count == 0)
            {
                listBoxPages.Invoke(new Action(() => listBoxPages.BackColor = Color.Gray));
                listBoxPages.Invoke(new Action(() => listBoxPages.Items.Add(k_NoLikes)));
            }
        }

        /// <summary>
        /// Fetch checkIns and show them in relevant textbox
        /// </summary>
        private void fetchCheckIn()
        {
            listBoxCheckIn.Invoke(new Action(() => listBoxCheckIn.HorizontalScrollbar = true));
            listBoxCheckIn.Invoke(new Action(() => listBoxCheckIn.DisplayMember = "Message"));
            foreach (Checkin fbCheckin in r_LoggedInUser.Checkins)
            {
                if (fbCheckin.Message != null)
                {
                    listBoxCheckIn.Invoke(new Action(() => listBoxCheckIn.Items.Add(fbCheckin)));
                }
            }

            if (r_LoggedInUser.Checkins.Count == 0)
            {
                listBoxCheckIn.Invoke(new Action(() => listBoxCheckIn.BackColor = Color.Gray));
                listBoxCheckIn.Invoke(new Action(() => listBoxCheckIn.Items.Add(k_NoCheckIns)));
            }
        }

        /// <summary>
        /// Fetch user photos
        /// </summary>
        private void fetchPhotos()
        {
            s_ListOfPhotos = new List<Photo>();
            
            foreach (Album album in r_LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    s_ListOfPhotos.Add(photo);
                }
            }

            if (s_ListOfPhotos.Count == 0)
            {
                buttonGetMostPhotos.Enabled = false;
                buttonFbBlueMostComments.Enabled = false;
            }
        }

        /// <summary>
        /// Fetch User posts and show them in relevant textbox
        /// </summary>
        private void fetchNewsFeed()
        {
            listBoxFeed.Invoke(new Action(() => listBoxFeed.HorizontalScrollbar = true));
            listBoxFeed.Invoke(new Action(() => postsBindingSource.DataSource = m_MyPosts));
        }

        /// <summary>
        /// Fetch user data and show it in relevant textbox
        /// </summary>
        private void fetchUserData()
        {
            listBoxProfie.Invoke(new Action(() => listBoxProfie.HorizontalScrollbar = true));
            pictureBoxProfile.LoadAsync(r_LoggedInUser.PictureNormalURL);
            if (r_LoggedInUser.Birthday != null)
            {
                listBoxProfie.Invoke(new Action(() => listBoxProfie.Items.Add("Birthday: " + r_LoggedInUser.Birthday)));
            }

            if (r_LoggedInUser.Gender != null)
            {
                listBoxProfie.Invoke(new Action(() => listBoxProfie.Items.Add("Gender: " + r_LoggedInUser.Gender)));
            }

            if (r_LoggedInUser.Hometown != null)
            {
                listBoxProfie.Invoke(new Action(() => listBoxProfie.Items.Add("Hometown: " + r_LoggedInUser.Hometown.Name)));
            }

            if (r_LoggedInUser.Email != null)
            {
                listBoxProfie.Invoke(new Action(() => listBoxProfie.Items.Add("Email: " + r_LoggedInUser.Email)));
            }
        }

        /// <summary>
        /// Post status in facebook wall
        /// </summary>
        /// <param name="i_Sender">Object sender</param>
        /// <param name="i_Event">The event</param>
        private void buttonPost_Click(object i_Sender, EventArgs i_Event)
        {
            Status postedStatus = r_LoggedInUser.PostStatus(postTextBox.Text);
            MyPost newPost = new MyPost(postTextBox.Text);
            m_MyPosts.Add(newPost);
            listBoxFeed.Invoke(new Action(() => listBoxFeed.Refresh()));
            MessageBox.Show(string.Format(@"Status: {0} Posted", postedStatus.Message));
        }

        /// <summary>
        /// Logout and exit application
        /// </summary>
        /// <param name="i_Sender">Object sender</param>
        /// <param name="i_Event">The event</param>
        private void buttonLogout_Click(object i_Sender, EventArgs i_Event)
        {
            Application.Exit();
        }
        
        /// <summary>
        /// Show 5 most likeable photos 
        /// </summary>
        /// <param name="i_Sender">Object sender</param>
        /// <param name="i_Event">The event</param>
        private void buttonTopLikeablePhotos_Click(object i_Sender, EventArgs i_Event)
        {
            MessageBox.Show(k_WaitMessage);

            foreach (Thread thread in r_Threads)
            {
                thread.Join();
            }

            r_FeatureReceiver.MostLikeablePhotos.Execute();
        }

        /// <summary>
        /// Show 5 most commentated photos
        /// </summary>
        /// <param name="i_Sender">the sender</param>
        /// <param name="i_Event">the event</param>
        private void buttonFbBlueMostComments_Click(object i_Sender, EventArgs i_Event)
        {
            MessageBox.Show(k_WaitMessage);

            foreach (Thread thread in r_Threads)
            {
                thread.Join();
            }

            r_FeatureReceiver.MostCommentatedPhotos.Execute();
        }

        /// <summary>
        /// Open new FormWhoWasBornOnMyBirthday instance.
        /// </summary>
        /// <param name="i_Sender">Object sender</param>
        /// <param name="i_Event">The event</param>
        private void buttonGetCelebsBD_Click(object i_Sender, EventArgs i_Event)
        {
            r_FeatureReceiver.WhoWasBornOnMyBirthday.Execute();
        }

        /// <summary>
        /// Gets all the photos of the user
        /// </summary>
        public static List<Photo> AllPhotos
        {
            get { return s_ListOfPhotos; }
        }

        /// <summary>
        /// Gets Birthday
        /// </summary>
        public static string Birthday
        {
            get { return s_Bdate; }
        }
    }
}
