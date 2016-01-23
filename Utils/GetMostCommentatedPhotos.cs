//-----------------------------------------------------------------------
// <copyright file="GetMostCommentatedPhotos.cs" company="A16_Ex03">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------

using System.Drawing;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace Utils
{
    /// <summary>
    /// Get the most commentated photos feature
    /// </summary>
    public class GetMostCommentatedPhotos : ICompare
    {
        /// <summary>
        /// The name
        /// </summary>
        /// <returns>the name</returns>
        public string Name()
        {
            return "Comments";
        }

        /// <summary>
        /// Current count
        /// </summary>
        /// <param name="i_Photo">Photo to check</param>
        /// <returns>Number of comments</returns>
        public int CurrentCount(Photo i_Photo)
        {
            return i_Photo.Comments.Count;
        }

        /// <summary>
        /// Return the photo with more number of comments
        /// </summary>
        /// <param name="i_FirstPhoto">First Photo</param>
        /// <param name="i_SecondPhoto">Second Photo</param>
        /// <returns>Photo with more comments</returns>
        public bool Decide(Photo i_FirstPhoto, Photo i_SecondPhoto)
        {
            return i_FirstPhoto.Comments.Count >= i_SecondPhoto.Comments.Count;
        }

        /// <summary>
        /// Sort the photos
        /// </summary>
        /// <param name="i_FirstPhoto">First photo</param>
        /// <param name="i_SecondPhoto">Second photo</param>
        /// <returns>Sorted photos</returns>
        public int Sorted(Photo i_FirstPhoto, Photo i_SecondPhoto)
        {
            return i_FirstPhoto.Comments.Count().CompareTo(i_SecondPhoto.Comments.Count());
        }

        /// <summary>
        /// Facebook comments photo
        /// </summary>
        /// <returns>Facebook comments image</returns>
        public Image Picture()
        {
            return new Bitmap("../../img/facebook_comments.png");
        }
    }
}
