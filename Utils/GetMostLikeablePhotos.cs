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
    public class GetMostLikeablePhotos : ICompare
    {
        public string Name()
        {
            return "Likes";
        }

        public int CurrentCount(Photo i_Photo)
        {
            return i_Photo.LikedBy.Count;
        }

        public bool Decide(Photo i_FirstPhoto, Photo i_SecondPhoto)
        {
            return i_FirstPhoto.LikedBy.Count >= i_SecondPhoto.LikedBy.Count;
        }

        public int Sorted(Photo i_FirstPhoto, Photo i_SecondPhoto)
        {
            return i_FirstPhoto.LikedBy.Count().CompareTo(i_SecondPhoto.LikedBy.Count());
        }

        public Image Picture()
        {
            return new Bitmap("../../img/facebook_like_button_hand.jpg");
        }
    }
}
