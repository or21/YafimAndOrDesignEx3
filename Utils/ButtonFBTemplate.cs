//-----------------------------------------------------------------------
// <copyright file="ButtonFbTemplate.cs" company="A16_Ex03">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------

using System.Drawing;
using System.Windows.Forms;

namespace Utils
{
    public abstract class ButtonFbTemplate : Button
    {
        public abstract void SetUniqueProperties();

        protected ButtonFbTemplate(int i_ButtonColorHex)
        {
            setBackgroundColor(i_ButtonColorHex);
            setFbButtonGeneralStyle();
        }

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
        private void setBackgroundColor(int i_HexColorValue)
        {
            Color tempRgbColor = Color.FromArgb(i_HexColorValue);
            BackColor = Color.FromArgb(tempRgbColor.R, tempRgbColor.G, tempRgbColor.B);
        }
    }
}
