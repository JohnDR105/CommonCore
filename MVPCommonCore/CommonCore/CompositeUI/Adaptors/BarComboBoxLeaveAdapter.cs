using CommonCore.CompositeUI.Actions;
// ***********************************************************************
// Assembly         : CNCFileGenerator
// Author           : John Reasor
// Created          : 03-10-2017
//
// Last Modified By : John Reasor
// Last Modified On : 03-10-2017
// ***********************************************************************
// <copyright file="BarComboBoxLeaveAdapter.cs" company="J&S Software, LLC">
//     Copyright © J&S Software, LLC 2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.CompositeUI.Adaptors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DevExpress.XtraBars;
    using DevExpress.XtraEditors.Repository;


    /// <summary>
    /// Class BarComboBoxLeaveAdapter.
    /// </summary>
    public class BarComboBoxLeaveAdapter
    {
        /// <summary>
        /// The action
        /// </summary>
        private readonly IControlAction action;

        /// <summary>
        /// Initializes a new instance of the <see cref="BarComboBoxLeaveAdapter"/> class.
        /// </summary>
        /// <param name="comboBox">The combo box.</param>
        /// <param name="action">The action.</param>
        public BarComboBoxLeaveAdapter(BarEditItem comboBox, IControlAction action)
        {
            this.action = action;
            var editor = comboBox.Edit as RepositoryItemComboBox;

            editor.Leave += this.Editor_Leave;
        }

        /// <summary>
        /// Creates the specified bar cb job identifier.
        /// </summary>
        /// <param name="barCBJobID">The bar cb job identifier.</param>
        /// <param name="jobIdLookUpAction">The job identifier look up action.</param>
        /// <returns>BarComboBoxEditChangedAdapter.</returns>
        public static BarComboBoxLeaveAdapter Create(BarEditItem barCBJobID, IControlAction jobIdLookUpAction)
        {
            return new BarComboBoxLeaveAdapter(barCBJobID, jobIdLookUpAction);
        }

        /// <summary>
        /// Handles the Leave event of the Editor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Editor_Leave(object sender, EventArgs e)
        {
            this.action.Execute();
        }
    }
}
