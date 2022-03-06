// ***********************************************************************
// Assembly         : CommonCore
// Author           : John Reasor
// Created          : 07-06-2017
//
// Last Modified By : John Reasor
// Last Modified On : 07-06-2017
// ***********************************************************************
// <copyright file="Account.cs" company="J&S Software, LLC">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.Models.Financial
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Persons;

    /// <summary>
    /// Class Account.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Gets or sets the account identifier.
        /// </summary>
        /// <value>The account identifier.</value>
        public int AccountID { get; set; }

        /// <summary>
        /// Gets or sets the name of the account nick.
        /// </summary>
        /// <value>The name of the account nick.</value>
        public string AccountNickName { get; set; }

        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        /// <value>The account number.</value>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the routing number.
        /// </summary>
        /// <value>The routing number.</value>
        public string RoutingNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the creditor.
        /// </summary>
        /// <value>The name of the creditor.</value>
        public string CreditorName { get; set; }

        /// <summary>
        /// Gets or sets the creditor address.
        /// </summary>
        /// <value>The creditor address.</value>
        public virtual Address CreditorAddress { get; set; }

        /// <summary>
        /// Gets or sets the creditor phone number.
        /// </summary>
        /// <value>The creditor phone number.</value>
        public virtual Phone CreditorPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the creditor email.
        /// </summary>
        /// <value>The creditor email.</value>
        public virtual Email CreditorEmail { get; set; }

        /// <summary>
        /// Gets or sets the account type enum.
        /// </summary>
        /// <value>The account type enum.</value>
        public Enum AccountTypeEnum { get; set; }

        /// <summary>
        /// Gets or sets the account notes.
        /// </summary>
        /// <value>The account notes.</value>
        public string AccountNotes { get; set; }

        /// <summary>
        /// Gets or sets the running balances.
        /// </summary>
        /// <value>The running balances.</value>
        public ICollection<RunningBalance> RunningBalances { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value><c>true</c> if this instance is active; otherwise, <c>false</c>.</value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is default account.
        /// </summary>
        /// <value><c>true</c> if this instance is default account; otherwise, <c>false</c>.</value>
        public bool IsDefaultAccount { get; set; }

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
