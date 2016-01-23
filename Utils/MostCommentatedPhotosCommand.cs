//-----------------------------------------------------------------------
// <copyright file="MostCommentatedPhotosCommand.cs" company="A16_Ex03">
// Yafim Vodkov 308973882 Or Brand id 302521034
// </copyright>
//-----------------------------------------------------------------------

using System;

namespace Utils
{
    /// <summary>
    /// Most commentated photos command
    /// </summary>
    public class MostCommentatedPhotosCommand : ICommand
    {
        /// <summary>
        /// The action to perform
        /// </summary>
        private readonly Action r_Action;

        /// <summary>
        /// Initializes a new instance of the MostCommentatedPhotosCommand class.
        /// </summary>
        /// <param name="i_Action">The action to perform</param>
        public MostCommentatedPhotosCommand(Action i_Action)
        {
            r_Action = i_Action;
        }

        /// <summary>
        /// Execute action
        /// </summary>
        public void Execute()
        {
            r_Action.Invoke();
        }
    }
}
