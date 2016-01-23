//-----------------------------------------------------------------------
// <copyright file="ButtonFbTemplate.cs" company="A16_Ex03">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------

using System.Drawing;
using System.Windows.Forms;

namespace Utils
{
    /// <summary>
    /// General template for fb buttons
    /// </summary>
    public abstract class ButtonFbTemplate : Button
    {
        /// <summary>
        /// Set Unique Properties for button
        /// </summary>
        public abstract void SetUniqueProperties();

        /// <summary>
        /// Initializes a new instance of the ButtonFbTemplate class.
        /// </summary>
        /// <param name="i_ButtonColorHex">Color of the button</param>
        protected ButtonFbTemplate(int i_ButtonColorHex)
        {
            setBackgroundColor(i_ButtonColorHex);
            setFbButtonGeneralStyle();
        }

        /// <summary>
        /// Set General facebook button style
        /// </summary>
        private void setFbButtonGeneralStyle()
        {
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 177);
            UseVisualStyleBackColor = false;
            FlatAppearance.BorderSize = 1;
        }

        /// <summary>
        /// Set background color.
        /// </summary>
        /// <param name="i_HexColorValue">Color in hex</param>
        private void setBackgroundColor(int i_HexColorValue)
        {
            Color tempRgbColor = Color.FromArgb(i_HexColorValue);
            BackColor = Color.FromArgb(tempRgbColor.R, tempRgbColor.G, tempRgbColor.B);
        }
    }
}
