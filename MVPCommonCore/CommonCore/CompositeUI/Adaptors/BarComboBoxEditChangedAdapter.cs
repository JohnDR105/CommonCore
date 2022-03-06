// ***********************************************************************
// Assembly         : DLMain
// Author           : John Reasor
// Created          : 02-17-2017
//
// Last Modified By : John Reasor
// Last Modified On : 02-17-2017
// ***********************************************************************
// <copyright file="BarComboBoxEditChangedAdapter.cs" company="J&S Software, LLC">
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

    using DevExpress.XtraBars;
    using DevExpress.XtraEditors.Repository;

    /// <summary>
    /// Class BarComboBoxEditChangedAdapter.
    /// </summary>
    public class BarComboBoxEditChangedAdapter
    {
        /// <summary>
        /// The action
        /// </summary>
        private readonly IControlAction action;


        /// <summary>
        /// Initializes a new instance of the <see cref="BarComboBoxEditChangedAdapter" /> class.
        /// </summary>
        /// <param name="comboBox">The combo box.</param>
        /// <param name="action">The action.</param>
        public BarComboBoxEditChangedAdapter(BarEditItem comboBox, IControlAction action)
        {
            this.action = action;
            var editor = comboBox.Edit as RepositoryItemComboBox;

            editor.EditValueChanged += this.Editor_EditValueChanged;
        }

        /// <summary>
        /// Creates the specified bar cb job identifier.
        /// </summary>
        /// <param name="barCBJobID">The bar cb job identifier.</param>
        /// <param name="jobIdLookUpAction">The job identifier look up action.</param>
        /// <returns>BarComboBoxEditChangedAdapter.</returns>
        public static BarComboBoxEditChangedAdapter Create(BarEditItem barCBJobID, IControlAction jobIdLookUpAction)
        {
            return new BarComboBoxEditChangedAdapter(barCBJobID, jobIdLookUpAction);
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
