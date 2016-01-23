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
        /// 
        /// </summary>
        public WhoWasBornOnMyBirthdayCommand WhoWasBornOnMyBirthday { get; private set; }

        public MostLikeablePhotosCommand MostLikeablePhotos { get; private set; }

        public MostCommentatedPhotosCommand MostCommentatedPhotos { get; private set; }

        public FeatureReceiver(FeatureBuilder i_FeaturesFactory)
        {
            m_FeaturesFactory = i_FeaturesFactory;
        }

        /// <summary>
        /// Create a new instance of the WhoWasBornOnMyBirthdayCommand class
        /// </summary>
        /// <param name="i_Type">The type</param>
        public void WhoWasBornOnMyBirthdayCommand(Type i_Type)
        {
            WhoWasBornOnMyBirthday = new WhoWasBornOnMyBirthdayCommand(() => m_FeaturesFactory.LoadFeature(i_Type, null));
        }

        public void MostLikeablePhotosCommand(Type i_Type, ICompare i_Compare)
        {
            MostLikeablePhotos = new MostLikeablePhotosCommand(() => m_FeaturesFactory.LoadFeature(i_Type, i_Compare));
        }

        public void MostCommentatedPhotosCommand(Type i_Type, ICompare i_Compare)
        {
            MostCommentatedPhotos = new MostCommentatedPhotosCommand(() => m_FeaturesFactory.LoadFeature(i_Type, i_Compare));
        }
    }
}
