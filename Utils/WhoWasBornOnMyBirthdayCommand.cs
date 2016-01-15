using System;

namespace Utils
{
    /// <summary>
    /// This is the ConcreteCommand class
    /// </summary>
    public class WhoWasBornOnMyBirthdayCommand : ICommand
    {
        /// <summary>
        /// The action to perform
        /// </summary>
        private readonly Action r_Action;

        /// <summary>
        /// Initializes a new instnace of the WhoWasBornOnMyBirthdayCommand class.
        /// </summary>
        /// <param name="i_Action">The action to perform</param>
        public WhoWasBornOnMyBirthdayCommand(Action i_Action)
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
