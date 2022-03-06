// ***********************************************************************
// Assembly         : JnSCommon
// Author           : John D Reasor
// Created          : 09-30-2016
//
// Last Modified By : John D Reasor
// Last Modified On : 09-30-2016
// ***********************************************************************
// <copyright file="ControlActionEnabledChangedEventArgs.cs" company="J&S Software, LLC">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.CompositeUI.Actions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Class ControlActionEnabledChangedEventArgs.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    /// <remarks>J&S Software, LLC</remarks>
    public class ControlActionEnabledChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlActionEnabledChangedEventArgs"/> class.
        /// </summary>
        /// <param name="enabled">if set to <c>true</c> [enabled].</param>
        /// <remarks>J&S Software, LLC</remarks>
        public ControlActionEnabledChangedEventArgs(bool enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Gets a value indicating whether this <see cref="ControlActionEnabledChangedEventArgs"/> is enabled.
        /// </summary>
        /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
        /// <remarks>J&S Software, LLC</remarks>
        public bool Enabled { get; private set; }
    }
}
