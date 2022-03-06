// ***********************************************************************
// Assembly         : CommonCore
// Author           : John Reasor
// Created          : 07-06-2017
//
// Last Modified By : John Reasor
// Last Modified On : 07-06-2017
// ***********************************************************************
// <copyright file="AccountTypeEnum.cs" company="J&S Software, LLC">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.Models.Financial
{
    using System;
    using System.Linq;

    /// <summary>
    /// Enum AccountTypeEnum
    /// </summary>
    public enum AccountTypeEnum
    {
        /// <summary>
        /// The checking
        /// </summary>
        Checking,

        /// <summary>
        /// The savings
        /// </summary>
        Savings,

        /// <summary>
        /// The credit card
        /// </summary>
        CreditCard,

        /// <summary>
        /// The debit card
        /// </summary>
        DebitCard
    }
}
