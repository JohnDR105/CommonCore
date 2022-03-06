// ***********************************************************************
// Assembly         : CommonCore
// Author           : John Reasor
// Created          : 07-05-2017
//
// Last Modified By : John Reasor
// Last Modified On : 07-05-2017
// ***********************************************************************
// <copyright file="Person.cs" company="J&S Software, LLC">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.Models.Persons
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using Financial;

    /// <summary>
    /// Class Person.
    /// </summary>
    [DebuggerDisplay("FirstName={FirstName}, LastName={LastName}, Date Of Birth={DOB}")]
    public abstract class Person
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the middle initial.
        /// </summary>
        /// <value>The middle initial.</value>
        public string MiddleInitial { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the name of the nick.
        /// </summary>
        /// <value>The name of the nick.</value>
        public string NickName { get; set; }

        /// <summary>
        /// Gets or sets the dob.
        /// </summary>
        /// <value>The Date of Birth.</value>
        public DateTime DOB { get; set; }

        /// <summary>
        /// Gets or sets the dod.
        /// </summary>
        /// <value>The Date of Death.</value>
        public DateTime DOD { get; set; }

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        /// <value>The addresses.</value>
        public virtual ICollection<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the phone numbers.
        /// </summary>
        /// <value>The phone numbers.</value>
        public virtual ICollection<Phone> PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or sets the emails.
        /// </summary>
        /// <value>The emails.</value>
        public virtual ICollection<Email> Emails { get; set; }

        /// <summary>
        /// Gets or sets the accounts.
        /// </summary>
        /// <value>The accounts.</value>
        public virtual ICollection<Account> Accounts { get; set; }

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
