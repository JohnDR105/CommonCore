// ***********************************************************************
// Assembly         : JnSCommon
// Author           : John D Reasor
// Created          : 10-01-2016
//
// Last Modified By : John D Reasor
// Last Modified On : 10-01-2016
// ***********************************************************************
// <copyright file="ExtendedBarButtonAdapter.cs" company="J&S Software, LLC">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.CompositeUI.Adaptors
{
    using CommonCore.CompositeUI.Actions;

    using DevExpress.XtraBars;

    /// <summary>
    /// Class ExtendedBarButtonAdapter.
    /// </summary>
    /// <seealso cref="JnSCommon.CompositeUI.Adaptors.BarButtonAdapter" />
    /// <remarks>J&S Software, LLC</remarks>
    public class ExtendedBarButtonAdapter : BarButtonAdapter
    {

        /// <summary>
        /// The button
        /// </summary>
        private BarButtonItem button;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedBarButtonAdapter"/> class.
        /// </summary>
        /// <param name="button">The button.</param>
        /// <param name="action">The action.</param>
        /// <remarks>J&S Software, LLC</remarks>
        public ExtendedBarButtonAdapter(BarButtonItem button, IControlAction action)
            : base(button, action)
        {
            this.button = button;

            this.button.Visibility = action.Visible ? BarItemVisibility.Always : BarItemVisibility.Never;
            this.button.Enabled = action.Enabled;

            action.VisibleChanged += this.Action_VisibleChanged;
            action.EnabledChanged += this.Action_EnabledChanged;
        }

        /// <summary>
        /// Creates the specified button.
        /// </summary>
        /// <param name="button">The button.</param>
        /// <param name="action">The action.</param>
        /// <returns>ExtendedBarButtonAdapter.</returns>
        /// <remarks>J&S Software, LLC</remarks>
        public static ExtendedBarButtonAdapter Create(BarButtonItem button, IControlAction action)
        {
            return new ExtendedBarButtonAdapter(button, action);
        }

        /// <summary>
        /// Handles the VisibleChanged event of the Action control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ControlActionVisibleChangedEventArgs"/> instance containing the event data.</param>
        /// <remarks>J&S Software, LLC</remarks>
        private void Action_VisibleChanged(object sender, ControlActionVisibleChangedEventArgs e)
        {
            this.button.Visibility = e.Visible ? BarItemVisibility.Always : BarItemVisibility.Never;
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
