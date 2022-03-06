// ***********************************************************************
// Assembly         : DLMain
// Author           : John Reasor
// Created          : 02-13-2017
//
// Last Modified By : John Reasor
// Last Modified On : 02-13-2017
// ***********************************************************************
// <copyright file="LookUpEditChangedAdapter.cs" company="J&S Software, LLC">
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

    public class LookUpEditChangedAdapter
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
        protected LookUpEditChangedAdapter(LookUpEdit editor, IControlAction action)
        {
            this.action = action;
            editor.EditValueChanged += this.Editor_EditValueChanged;
        }

        /// <summary>
        /// Creates the specified editor.
        /// </summary>
        /// <param name="editor">The editor.</param>
        /// <param name="action">The action.</param>
        /// <returns>DLMain.CompositeUI.Adaptors.LookUpEditAdapter.</returns>
        public static LookUpEditChangedAdapter Create(LookUpEdit editor, IControlAction action)
        {
            return new LookUpEditChangedAdapter(editor, action);
        }

        /// <summary>
        /// Handles the EditValueChanged event of the Editor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Editor_EditValueChanged(object sender, EventArgs e)
        {
           this.action.Execute();
        }
    }
}
