// ***********************************************************************
// Assembly         : DLMain
// Author           : John Reasor
// Created          : 02-13-2017
//
// Last Modified By : John Reasor
// Last Modified On : 02-13-2017
// ***********************************************************************
// <copyright file="ComboBoxEditChangedAdapter.cs" company="J&S Software, LLC">
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
    /// Class ComboBoxEditChangedAdapter.
    /// </summary>
    public class ComboBoxEditChangedAdapter
    {
        /// <summary>
        /// The action
        /// </summary>
        private readonly IControlAction action;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComboBoxEditChangedAdapter" /> class.
        /// </summary>
        /// <param name="editor">The editer.</param>
        /// <param name="action">The action.</param>
        protected ComboBoxEditChangedAdapter(ComboBoxEdit editor, IControlAction action)
        {
            this.action = action;
            editor.EditValueChanged += this.Editor_EditValueChanged;
        }

        /// <summary>
        /// Creates the specified cb purlin depth.
        /// </summary>
        /// <param name="editor">The editor.</param>
        /// <param name="action">The action.</param>
        /// <returns>ComboBoxEditAdapter.</returns>
        public static ComboBoxEditChangedAdapter Create(ComboBoxEdit editor, IControlAction action)
        {
            return new ComboBoxEditChangedAdapter(editor, action);
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
