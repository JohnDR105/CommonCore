// ***********************************************************************
// Assembly         : DLMain
// Author           : John Reasor
// Created          : 02-02-2017
//
// Last Modified By : John Reasor
// Last Modified On : 02-02-2017
// ***********************************************************************
// <copyright file="LookUpEditClickAdapter.cs" company="J&S Software, LLC">
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
    /// Class LookUpEditClickAdapter.
    /// </summary>
    public class LookUpEditClickAdapter
    {
        /// <summary>
        /// The action
        /// </summary>
        private readonly IControlAction action;

        /// <summary>
        /// Initializes a new instance of the <see cref="LookUpEditAdapter" /> class.
        /// </summary>
        /// <param name="editor">The editor.</param>
        /// <param name="action">The action.</param>
        protected LookUpEditClickAdapter(LookUpEdit editor, IControlAction action)
        {
            this.action = action;
            editor.Click += this.Editor_Click;
        }

        /// <summary>
        /// Creates the specified editor.
        /// </summary>
        /// <param name="editor">The editor.</param>
        /// <param name="action">The action.</param>
        /// <returns>DLMain.CompositeUI.Adaptors.LookUpEditAdapter.</returns>
        public static LookUpEditClickAdapter Create(LookUpEdit editor, IControlAction action)
        {
            return new LookUpEditClickAdapter(editor, action);
        }

        /// <summary>
        /// Editors the click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void Editor_Click(object sender, EventArgs e)
        {
            this.action.Execute();
        }
    }
}
