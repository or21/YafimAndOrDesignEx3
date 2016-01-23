//-----------------------------------------------------------------------
// <copyright file="GetMostLikeablePhotos.cs" company="A16_Ex03">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------

using System.Drawing;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace Utils
{
    /// <summary>
    /// Get most likeable photos feature
    /// </summary>
    public class GetMostLikeablePhotos : ICompare
    {
        /// <summary>
        /// The name
        /// </summary>
        /// <returns>the name</returns>
        public string Name()
        {
            return "Likes";
        }

        /// <summary>
        /// Current count
        /// </summary>
        /// <param name="i_Photo">Photo to check</param>
        /// <returns>Number of likes</returns>
        public int CurrentCount(Photo i_Photo)
        {
            return i_Photo.LikedBy.Count;
        }

        /// <summary>
        /// Return the photo with more number of likes
        /// </summary>
        /// <param name="i_FirstPhoto">First Photo</param>
        /// <param name="i_SecondPhoto">Second Photo</param>
        /// <returns>Photo with more likes</returns>
        public bool Decide(Photo i_FirstPhoto, Photo i_SecondPhoto)
        {
            return i_FirstPhoto.LikedBy.Count >= i_SecondPhoto.LikedBy.Count;
        }

        /// <summary>
        /// Sort the photos
        /// </summary>
        /// <param name="i_FirstPhoto">First photo</param>
        /// <param name="i_SecondPhoto">Second photo</param>
        /// <returns>Sorted photos</returns>
        public int Sorted(Photo i_FirstPhoto, Photo i_SecondPhoto)
        {
            return i_FirstPhoto.LikedBy.Count().CompareTo(i_SecondPhoto.LikedBy.Count());
        }

        /// <summary>
        /// Facebook like photo
        /// </summary>
        /// <returns>Facebook like image</returns>
        public Image Picture()
        {
            return new Bitmap("../../img/facebook_like_button_hand.jpg");
        }
    }
}
