// ***********************************************************************
// Assembly         : JnSCommon
// Author           : John
// Created          : 09-30-2016
//
// Last Modified By : John
// Last Modified On : 09-30-2016
// ***********************************************************************
// <copyright file="ButtonAdapter.cs" company="J&S Software, LLC">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.CompositeUI.Adaptors
{
    using System;

    using CommonCore.CompositeUI.Actions;

    using DevExpress.XtraEditors;

    /// <summary>
    /// Class ButtonAdapter.
    /// </summary>
    public class ButtonAdapter
    {
        /// <summary>
        /// The action
        /// </summary>
        private readonly IAction action;

        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonAdapter" /> class.
        /// </summary>
        /// <param name="button">The button.</param>
        /// <param name="action">The action.</param>
        public ButtonAdapter(SimpleButton button, IAction action)
        {
            this.action = action;
            button.Click += button_Click;
        }

        /// <summary>
        /// Creates the specified button.
        /// </summary>
        /// <param name="button">The button.</param>
        /// <param name="action">The action.</param>
        /// <returns>ButtonAdapter.</returns>
        public static ButtonAdapter Create(SimpleButton button, IAction action)
        {
            return new ButtonAdapter(button, action);
        }

        /// <summary>
        /// Handles the Click event of the button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void button_Click(object sender, EventArgs e)
        {
            this.action.Execute();
        }

    }
}
