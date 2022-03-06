// ***********************************************************************
// Assembly         : CommonCore
// Author           : John Reasor
// Created          : 07-06-2017
//
// Last Modified By : John Reasor
// Last Modified On : 07-06-2017
// ***********************************************************************
// <copyright file="RunningBalance.cs" company="J&S Software, LLC">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.Models.Financial
{
    using System;
    using System.Linq;

    /// <summary>
    /// Class RunningBalance.
    /// </summary>
    public class RunningBalance
    {
        /// <summary>
        /// Gets or sets the running balance identifier.
        /// </summary>
        /// <value>The running balance identifier.</value>
        public int RunningBalanceID { get; set; }

        /// <summary>
        /// Gets or sets the previous balance.
        /// </summary>
        /// <value>The previous balance.</value>
        public decimal PreviousBalance { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the new balance.
        /// </summary>
        /// <value>The new balance.</value>
        public decimal NewBalance { get; set; }

        /// <summary>
        /// Gets or sets the date created.
        /// </summary>
        /// <value>The date created.</value>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the date modified.
        /// </summary>
        /// <value>The date modified.</value>
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Gets or sets the user created.
        /// </summary>
        /// <value>The user created.</value>
        public int UserCreated { get; set; }

        /// <summary>
        /// Gets or sets the user modified.
        /// </summary>
        /// <value>The user modified.</value>
        public int UserModified { get; set; }
    }
}
