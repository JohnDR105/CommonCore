// ***********************************************************************
// Assembly         : JnSCommon
// Author           : John D Reasor
// Created          : 10-01-2016
//
// Last Modified By : John D Reasor
// Last Modified On : 10-01-2016
// ***********************************************************************
// <copyright file="ExtendedButtonAdapter.cs" company="J&S Software, LLC">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.CompositeUI.Adaptors
{
    using CommonCore.CompositeUI.Actions;

    using DevExpress.XtraEditors;

    /// <summary>
    /// Class ExtendedButtonAdapter.
    /// </summary>
    /// <seealso cref="JnSCommon.CompositeUI.Adaptors.ButtonAdapter" />
    /// <remarks>J&S Software, LLC</remarks>
    class ExtendedButtonAdapter : ButtonAdapter
    {
        /// <summary>
        /// The button
        /// </summary>
        private SimpleButton button;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedButtonAdapter" /> class.
        /// </summary>
        /// <param name="button">The button.</param>
        /// <param name="action">The action.</param>
        /// <remarks>J&S Software, LLC</remarks>
        public ExtendedButtonAdapter(SimpleButton button, IControlAction action)
            : base(button, action)
        {
            this.button = button;

            this.button.Visible = action.Visible;
            this.button.Enabled = action.Enabled;

            action.VisibleChanged += this.Action_VisibleChanged;
            action.EnabledChanged += this.Action_EnabledChanged;
        }

        /// <summary>
        /// Creates the specified button.
        /// </summary>
        /// <param name="button">The button.</param>
        /// <param name="action">The action.</param>
        /// <returns>ExtendedButtonAdapter.</returns>
        /// <remarks>J&S Software, LLC</remarks>
        public static ExtendedButtonAdapter Create(SimpleButton button, IControlAction action)
        {
            return new ExtendedButtonAdapter(button, action);
        }

        /// <summary>
        /// Handles the VisibleChanged event of the Action control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ControlActionVisibleChangedEventArgs"/> instance containing the event data.</param>
        /// <remarks>J&S Software, LLC</remarks>
        private void Action_VisibleChanged(object sender, ControlActionVisibleChangedEventArgs e)
        {
            this.button.Visible = e.Visible;
        }

        /// <summary>
        /// Handles the EnabledChanged event of the Action control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ControlActionEnabledChangedEventArgs"/> instance containing the event data.</param>
        /// <remarks>J&S Software, LLC</remarks>
        private void Action_EnabledChanged(object sender, ControlActionEnabledChangedEventArgs e)
        {
            this.button.Enabled = e.Enabled;
        }
    }
}
