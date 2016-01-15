//-----------------------------------------------------------------------
// <copyright file="FormComparedPhotos.Designer.cs" company="A16_Ex02">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------
using System.Windows.Forms;

namespace AppUI
{
    /// <summary>
    /// Get the N likeable pictures you have on facebook.
    /// </summary>
    public partial class FormComparedPhotos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComparedPhotos));
            this.buttonNext = new Utils.ButtonFbBlue();
            this.buttonTopPicture = new Utils.ButtonFbBlue();
            this.buttonBack = new Utils.ButtonFbBlue();
            this.buttonExit = new Utils.ButtonFbWhite();
            this.labelNumberOfObjects = new System.Windows.Forms.Label();
            this.pictureBoxCurrentPic = new System.Windows.Forms.PictureBox();
            this.pictureBoxIconFeature = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconFeature)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(281, 424);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(80, 23);
            this.buttonNext.TabIndex = 36;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonTopPicture
            // 
            this.buttonTopPicture.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonTopPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.buttonTopPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTopPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonTopPicture.ForeColor = System.Drawing.Color.White;
            this.buttonTopPicture.Location = new System.Drawing.Point(192, 424);
            this.buttonTopPicture.Name = "buttonTopPicture";
            this.buttonTopPicture.Size = new System.Drawing.Size(80, 23);
            this.buttonTopPicture.TabIndex = 35;
            this.buttonTopPicture.Text = "Reset";
            this.buttonTopPicture.UseVisualStyleBackColor = true;
            this.buttonTopPicture.Click += new System.EventHandler(this.buttonTopPicture_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(101, 424);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(80, 23);
            this.buttonBack.TabIndex = 34;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(161, 33);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(154, 27);
            this.buttonExit.TabIndex = 32;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelNumberOfObjects
            // 
            this.labelNumberOfObjects.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelNumberOfObjects.AutoSize = true;
            this.labelNumberOfObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumberOfObjects.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelNumberOfObjects.Location = new System.Drawing.Point(202, 387);
            this.labelNumberOfObjects.Name = "labelNumberOfObjects";
            this.labelNumberOfObjects.Size = new System.Drawing.Size(0, 29);
            this.labelNumberOfObjects.TabIndex = 38;
            // 
            // pictureBoxCurrentPic
            // 
            this.pictureBoxCurrentPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCurrentPic.Location = new System.Drawing.Point(12, 66);
            this.pictureBoxCurrentPic.Name = "pictureBoxCurrentPic";
            this.pictureBoxCurrentPic.Size = new System.Drawing.Size(444, 315);
            this.pictureBoxCurrentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCurrentPic.TabIndex = 40;
            this.pictureBoxCurrentPic.TabStop = false;
            // 
            // pictureBoxIconFeature
            // 
            this.pictureBoxIconFeature.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxIconFeature.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconFeature.Image")));
            this.pictureBoxIconFeature.Location = new System.Drawing.Point(140, 386);
            this.pictureBoxIconFeature.Name = "pictureBoxIconFeature";
            this.pictureBoxIconFeature.Size = new System.Drawing.Size(41, 30);
            this.pictureBoxIconFeature.TabIndex = 41;
            this.pictureBoxIconFeature.TabStop = false;
            // 
            // FormComparedPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 459);
            this.Controls.Add(this.pictureBoxIconFeature);
            this.Controls.Add(this.labelNumberOfObjects);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonTopPicture);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBoxCurrentPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormComparedPhotos";
            this.Text = "MostLikeablePhotosForm";
            this.Load += new System.EventHandler(this.buttonTopPicture_Click);
            this.Controls.SetChildIndex(this.pictureBoxCurrentPic, 0);
            this.Controls.SetChildIndex(this.buttonExit, 0);
            this.Controls.SetChildIndex(this.buttonBack, 0);
            this.Controls.SetChildIndex(this.buttonTopPicture, 0);
            this.Controls.SetChildIndex(this.buttonNext, 0);
            this.Controls.SetChildIndex(this.labelNumberOfObjects, 0);
            this.Controls.SetChildIndex(this.pictureBoxIconFeature, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconFeature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// Button next picture
        /// </summary>
        private Utils.ButtonFbBlue buttonNext;

        /// <summary>
        /// Button most likeable picture
        /// </summary>
        private Utils.ButtonFbBlue buttonTopPicture;

        /// <summary>
        /// Button previous picture
        /// </summary>
        private Utils.ButtonFbBlue buttonBack;

        /// <summary>
        /// Close form
        /// </summary>
        private Utils.ButtonFbWhite buttonExit;

        /// <summary>
        /// Label of Number of likes
        /// </summary>
        private Label labelNumberOfObjects;

        /// <summary>
        /// Show current photo
        /// </summary>
        private PictureBox pictureBoxCurrentPic;

        /// <summary>
        /// Image of facebook like
        /// </summary>
        private PictureBox pictureBoxIconFeature;
    }
}