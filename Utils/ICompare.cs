//-----------------------------------------------------------------------
// <copyright file="ICompare.cs" company="A16_Ex03">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------

using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace Utils
{
    public interface ICompare
    {
        string Name();

        int CurrentCount(Photo i_Photo);

        bool Decide(Photo i_FirstPhoto, Photo i_SecondPhoto);

        int Sorted(Photo i_FirstPhoto, Photo i_SecondPhoto);
        
        Image Picture();
    }
}
