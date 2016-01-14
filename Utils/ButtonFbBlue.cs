﻿//-----------------------------------------------------------------------
// <copyright file="ButtonFbBlue.cs" company="A16_Ex02">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------
using System.Drawing;
using System.Windows.Forms;

namespace Utils
{
    /// <summary>
    /// Facebook UI blue button
    /// </summary>
    public sealed class ButtonFbBlue : Button
    {
        /// <summary>
        /// Initializes a new instance of the FbBlueButton class.
        /// </summary>
        public ButtonFbBlue()
        {
            setUniqueProperties();
        }

        /// <summary>
        /// Set background color.
        /// </summary>
        private void setBackgroundColor()
        {
            Color tempRgbColor = Color.FromArgb(0x617AAC);
            BackColor = Color.FromArgb(tempRgbColor.R, tempRgbColor.G, tempRgbColor.B);
        }

        /// <summary>
        /// Set some unique properties to the button
        /// </summary>
        private void setUniqueProperties()
        {
            setBackgroundColor();
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 177);
            ForeColor = Color.White;
            Name = "fbBlueButton";
            UseVisualStyleBackColor = false;

            FlatAppearance.BorderColor = Color.Blue;
            FlatAppearance.BorderSize = 1;
        }   
    }
}
