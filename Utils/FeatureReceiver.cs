//-----------------------------------------------------------------------
// <copyright file="FeatureReceiver.cs" company="A16_Ex03">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------

using System;

namespace Utils
{
    /// <summary>
    /// This is the Receiver class.
    /// </summary>
    public class FeatureReceiver
    {
        /// <summary>
        /// Feature builder
        /// </summary>
        private readonly FeatureBuilder m_FeaturesFactory;

        /// <summary>
        /// Gets and sets WhoWasBornOnMyBirthdayCommand
        /// </summary>
        public WhoWasBornOnMyBirthdayCommand WhoWasBornOnMyBirthday { get; private set; }

        /// <summary>
        /// Gets and sets MostLikeablePhotosCommand
        /// </summary>
        public MostLikeablePhotosCommand MostLikeablePhotos { get; private set; }

        /// <summary>
        /// Gets and sets MostCommentatedPhotosCommand 
        /// </summary>
        public MostCommentatedPhotosCommand MostCommentatedPhotos { get; private set; }

        /// <summary>
        /// Initializes a new instance of the FeatureReceiver class.
        /// </summary>
        /// <param name="i_FeaturesFactory">Factory instance</param>
        public FeatureReceiver(FeatureBuilder i_FeaturesFactory)
        {
            m_FeaturesFactory = i_FeaturesFactory;
        }

        /// <summary>
        /// Create a new instance of the WhoWasBornOnMyBirthdayCommand class
        /// </summary>
        /// <param name="i_Type">Type of the feature</param>
        public void WhoWasBornOnMyBirthdayCommand(Type i_Type)
        {
            WhoWasBornOnMyBirthday = new WhoWasBornOnMyBirthdayCommand(() => m_FeaturesFactory.LoadFeature(i_Type, null));
        }

        /// <summary>
        /// MostLikeablePhotosCommand to execute
        /// </summary>
        /// <param name="i_Type">Type of the feature</param>
        /// <param name="i_Compare">Strategy method</param>
        public void MostLikeablePhotosCommand(Type i_Type, ICompare i_Compare)
        {
            MostLikeablePhotos = new MostLikeablePhotosCommand(() => m_FeaturesFactory.LoadFeature(i_Type, i_Compare));
        }

        /// <summary>
        /// MostCommentatedPhotosCommand to execute
        /// </summary>
        /// <param name="i_Type">Type of the feature</param>
        /// <param name="i_Compare">Strategy method</param>
        public void MostCommentatedPhotosCommand(Type i_Type, ICompare i_Compare)
        {
            MostCommentatedPhotos = new MostCommentatedPhotosCommand(() => m_FeaturesFactory.LoadFeature(i_Type, i_Compare));
        }
    }
}
