// ***********************************************************************
// Assembly         : DLMain
// Author           : John Reasor
// Created          : 02-02-2017
//
// Last Modified By : John Reasor
// Last Modified On : 02-02-2017
// ***********************************************************************
// <copyright file="ComboBoxEditClickAdapter.cs" company="J&S Software, LLC">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.CompositeUI.Adaptors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Actions;

    using DevExpress.XtraEditors;

    /// <summary>
    /// Class ComboBoxEditClickAdapter.
    /// </summary>
    public class ComboBoxEditClickAdapter
    {
        /// <summary>
        /// The action
        /// </summary>
        private readonly IControlAction action;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComboBoxEditAdapter" /> class.
        /// </summary>
        /// <param name="editor">The editer.</param>
        /// <param name="Action">The action.</param>
        protected ComboBoxEditClickAdapter(ComboBoxEdit editor, IControlAction Action)
        {
            this.action = Action;

            editor.Click += this.Editor_Click;
        }

        /// <summary>
        /// Creates the specified cb purlin depth.
        /// </summary>
        /// <param name="editor">The editor.</param>
        /// <param name="action">The action.</param>
        /// <returns>ComboBoxEditAdapter.</returns>
        public static ComboBoxEditClickAdapter Create(ComboBoxEdit editor, IControlAction action)
        {
            return new ComboBoxEditClickAdapter(editor, action);
        }

        /// <summary>
        /// Handles the Click event of the Editer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Editor_Click(object sender, EventArgs e)
        {
            this.action.Execute();
        }
    }
}
