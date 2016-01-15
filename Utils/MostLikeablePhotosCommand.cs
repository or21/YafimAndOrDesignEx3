using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class MostLikeablePhotosCommand : ICommand
    {
        /// <summary>
        /// The action to perform
        /// </summary>
        private readonly Action r_Action;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i_Action">The action to perform</param>
        public MostLikeablePhotosCommand(Action i_Action)
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
