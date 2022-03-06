// ***********************************************************************
// Assembly         : JnSCommon
// Author           : John D Reasor
// Created          : 09-30-2016
//
// Last Modified By : John D Reasor
// Last Modified On : 09-30-2016
// ***********************************************************************
// <copyright file="PresenterAction.cs" company="J&S Software, LLC">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.CompositeUI.Actions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Delegate ExceptionAction
    /// </summary>
    /// <param name="ex">The ex.</param>
    /// <remarks>J&S Software, LLC</remarks>
    public delegate void ExceptionAction(Exception ex);

    /// <summary>
    /// Class PresenterAction.
    /// </summary>
    /// <seealso cref="JnSCommon.CompositeUI.Actions.IAction" />
    /// <remarks>J&S Software, LLC</remarks>
    public class PresenterAction : IAction
    {
        /// <summary>
        /// The action
        /// </summary>
        private readonly Action action;

        /// <summary>
        /// The exception action
        /// </summary>
        private readonly ExceptionAction exceptionAction;

        /// <summary>
        /// Initializes a new instance of the <see cref="PresenterAction"/> class.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <remarks>J&S Software, LLC</remarks>
        public PresenterAction(Action action)
        {
            this.action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresenterAction"/> class.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <param name="exceptionAction">The exception action.</param>
        /// <remarks>J&S Software, LLC</remarks>
        public PresenterAction(Action action, ExceptionAction exceptionAction)
        {
            this.action = action;
            this.exceptionAction = exceptionAction;
        }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        /// <remarks>J&S Software, LLC</remarks>
        public virtual void Execute()
        {
            if (this.exceptionAction != null)
            {
                try
                {
                    this.action();
                }
                catch (Exception ex)
                {
                    this.exceptionAction(ex);
                }
            }
            else
            {
                this.action();
            }
        }
    }
}
