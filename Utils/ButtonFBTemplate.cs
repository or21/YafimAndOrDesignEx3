using System.Drawing;
using System.Windows.Forms;

namespace Utils
{
    public abstract class ButtonFBTemplate : Button
    {
        public abstract void SetUniqueProperties();

        protected ButtonFBTemplate(int i_ButtonColorHEX)
        {
            setBackgroundColor(i_ButtonColorHEX);
            setFBButtonGeneralStyle();
        }

        private void setFBButtonGeneralStyle()
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
