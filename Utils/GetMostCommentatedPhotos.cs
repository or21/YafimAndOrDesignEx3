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
    public class GetMostCommentatedPhotos : ICompare
    {
        public string Name()
        {
            return "Comments";
        }

        public int CurrentCount(Photo i_Photo)
        {
            return i_Photo.Comments.Count;
        }

        public bool Decide(Photo i_FirstPhoto, Photo i_SecondPhoto)
        {
            return i_FirstPhoto.Comments.Count >= i_SecondPhoto.Comments.Count;
        }

        public int Sorted(Photo i_FirstPhoto, Photo i_SecondPhoto)
        {
            return i_FirstPhoto.Comments.Count().CompareTo(i_SecondPhoto.Comments.Count());
        }

        public Image Picture()
        {
            return new Bitmap("../../img/facebook_comments.png");
        }
    }
}
