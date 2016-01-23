//-----------------------------------------------------------------------
// <copyright file="ButtonFbBlue.cs" company="A16_Ex03">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------

using System.Drawing;

namespace Utils
{
    /// <summary>
    /// Facebook UI blue button
    /// </summary>
    public sealed class ButtonFbBlue : ButtonFbTemplate
    {
        /// <summary>
        /// Initializes a new instance of the ButtonFbBlue class.
        /// </summary>
        public ButtonFbBlue()
            : base(0x617AAC)
        {
            SetUniqueProperties();
        }

        /// <summary>
        /// Set Unique Properties
        /// </summary>
        public override void SetUniqueProperties()
        {
            ForeColor = Color.White;
            Name = "fbBlueButton";
            FlatAppearance.BorderColor = Color.Blue;
        }
    }
}
