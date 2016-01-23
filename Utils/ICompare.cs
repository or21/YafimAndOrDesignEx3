//-----------------------------------------------------------------------
// <copyright file="ICompare.cs" company="A16_Ex03">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------

using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace Utils
{
    /// <summary>
    /// ICompare interface
    /// </summary>
    public interface ICompare
    {
        /// <summary>
        /// The name
        /// </summary>
        /// <returns>the name</returns>
        string Name();

        /// <summary>
        /// Current count
        /// </summary>
        /// <param name="i_Photo">Photo to check</param>
        /// <returns>the current count</returns>
        int CurrentCount(Photo i_Photo);

        /// <summary>
        /// Return the photo higher count
        /// </summary>
        /// <param name="i_FirstPhoto">First Photo</param>
        /// <param name="i_SecondPhoto">Second Photo</param>
        /// <returns>Photo with more...</returns>
        bool Decide(Photo i_FirstPhoto, Photo i_SecondPhoto);

        /// <summary>
        /// Sort the photos
        /// </summary>
        /// <param name="i_FirstPhoto">First photo</param>
        /// <param name="i_SecondPhoto">Second photo</param>
        /// <returns>Sorted photos</returns>
        int Sorted(Photo i_FirstPhoto, Photo i_SecondPhoto);

        /// <summary>
        /// Facebook comments photo
        /// </summary>
        /// <returns>Facebook image</returns>
        Image Picture();
    }
}
