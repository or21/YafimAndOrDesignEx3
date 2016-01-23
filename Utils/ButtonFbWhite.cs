//-----------------------------------------------------------------------
// <copyright file="ButtonFbWhite.cs" company="A16_Ex03">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------
using System.Drawing;

namespace Utils
{
    /// <summary>
    /// Facebook UI white button
    /// </summary>
    public sealed class ButtonFbWhite : ButtonFbTemplate
    {
        /// <summary>
        /// Initializes a new instance of the ButtonFbWhite class.
        /// </summary>
        public ButtonFbWhite()
            : base(0xffffff)
        {
            SetUniqueProperties();
        }

        public override void SetUniqueProperties()
        {
            ForeColor = Color.Black;
            Name = "fbWhiteButton";

            FlatAppearance.BorderColor = Color.Black;
        }
    }
}
