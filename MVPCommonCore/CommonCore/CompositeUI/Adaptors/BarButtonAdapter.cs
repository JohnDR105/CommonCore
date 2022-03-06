// ***********************************************************************
// Assembly         : JnSCommon
// Author           : John
// Created          : 09-30-2016
//
// Last Modified By : John
// Last Modified On : 09-30-2016
// ***********************************************************************
// <copyright file="BarButtonAdapter.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.CompositeUI.Adaptors
{
    using System;

    using DevExpress.XtraBars;

    using CommonCore.CompositeUI.Actions;

    /// <summary>
    /// Class BarButtonAdapter.
    /// </summary>
    public class BarButtonAdapter
    {

        /// <summary>
        /// The action
        /// </summary>
        private readonly IAction action;

        /// <summary>
        /// Initializes a new instance of the <see cref="BarButtonAdapter" /> class.
        /// </summary>
        /// <param name="button">The button.</param>
        /// <param name="action">The action.</param>
        public BarButtonAdapter(BarButtonItem button, IAction action)
        {
            this.action = action;
            button.ItemClick += this.Button_ItemClick;
        }

        /// <summary>
        /// Creates the specified button.
        /// </summary>
        /// <param name="button">The button.</param>
        /// <param name="action">The action.</param>
        /// <returns>BarButtonAdapter.</returns>
        public static BarButtonAdapter Create(BarButtonItem button, IAction action)
        {
            return new BarButtonAdapter(button, action);
        }

        /// <summary>
        /// Handles the ItemClick event of the Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ItemClickEventArgs"/> instance containing the event data.</param>
        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.action.Execute();
        }
    }
}
