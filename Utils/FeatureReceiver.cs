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
        private readonly FeaturesBuilder m_FeaturesFactory;

        /// <summary>
        /// 
        /// </summary>
        public WhoWasBornOnMyBirthdayCommand WhoWasBornOnMyBirthday { get; private set; }

        public MostLikeablePhotosCommand MostLikeablePhotos { get; private set; }

        public FeatureReceiver(FeaturesBuilder i_FeaturesFactory)
        {
            m_FeaturesFactory = i_FeaturesFactory;
        }

        /// <summary>
        /// Create a new instance of the WhoWasBornOnMyBirthdayCommand class
        /// </summary>
        /// <param name="i_Type">The type</param>
        public void WhoWasBornOnMyBirthdayCommand(Type i_Type)
        {
            WhoWasBornOnMyBirthday = new WhoWasBornOnMyBirthdayCommand(() => m_FeaturesFactory.LoadFeature(i_Type));
        }

        public void MostLikeablePhotosCommand(Type i_Type)
        {
            MostLikeablePhotos = new MostLikeablePhotosCommand(() => m_FeaturesFactory.LoadFeature(i_Type));
        }
    }
}
