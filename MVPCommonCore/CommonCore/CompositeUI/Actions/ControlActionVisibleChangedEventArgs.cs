// ***********************************************************************
// Assembly         : JnSCommon
// Author           : John D Reasor
// Created          : 09-30-2016
//
// Last Modified By : John D Reasor
// Last Modified On : 09-30-2016
// ***********************************************************************
// <copyright file="ControlActionVisibleChangedEventArgs.cs" company="J&S Software, LLC">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.CompositeUI.Actions
{
    using System;

    /// <summary>
    /// Class ControlActionVisibleChangedEventArgs.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    /// <remarks>J&S Software, LLC</remarks>
    public class ControlActionVisibleChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlActionVisibleChangedEventArgs" /> class.
        /// </summary>
        /// <param name="visible">if set to <c>true</c> [enabled].</param>
        /// <remarks>J&S Software, LLC</remarks>
        public ControlActionVisibleChangedEventArgs(bool visible)
        {
            this.Visible = visible;
        }

        /// <summary>
        /// Gets a value indicating whether this <see cref="ControlActionVisibleChangedEventArgs"/> is enabled.
        /// </summary>
        /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
        /// <remarks>J&S Software, LLC</remarks>
        public bool Visible { get; private set; }
    }
}