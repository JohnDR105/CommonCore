// ***********************************************************************
// Assembly         : JnSCommon
// Author           : John D Reasor
// Created          : 09-30-2016
//
// Last Modified By : John D Reasor
// Last Modified On : 09-30-2016
// ***********************************************************************
// <copyright file="IControlAction.cs" company="J&S Software, LLC">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.CompositeUI.Actions
{
    using System;

    /// <summary>
    /// Interface IControlAction
    /// </summary>
    /// <seealso cref="JnSCommon.CompositeUI.Actions.IAction" />
    /// <remarks>J&S Software, LLC</remarks>
    public interface IControlAction : IAction
    {
        /// <summary>
        /// Occurs when [enabled changed].
        /// </summary>
        /// <remarks>J&S Software, LLC</remarks>
        event EventHandler<ControlActionEnabledChangedEventArgs> EnabledChanged;
        /// <summary>
        /// Occurs when [visible changed].
        /// </summary>
        /// <remarks>J&S Software, LLC</remarks>
        event EventHandler<ControlActionVisibleChangedEventArgs> VisibleChanged;

        /// <summary>
        /// Gets a value indicating whether this <see cref="IControlAction"/> is visible.
        /// </summary>
        /// <value><c>true</c> if visible; otherwise, <c>false</c>.</value>
        /// <remarks>J&S Software, LLC</remarks>
        bool Visible { get; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="IControlAction"/> is enabled.
        /// </summary>
        /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
        /// <remarks>J&S Software, LLC</remarks>
        bool Enabled { get; }


    }
}
