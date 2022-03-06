// ***********************************************************************
// Assembly         : CommonCore
// Author           : John Reasor
// Created          : 07-05-2017
//
// Last Modified By : John Reasor
// Last Modified On : 07-05-2017
// ***********************************************************************
// <copyright file="Email.cs" company="J&S Software, LLC">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.Models.Persons
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    /// <summary>
    /// Class Email.
    /// </summary>
    public class Email
    {
        /// <summary>
        /// Gets or sets the email identifier.
        /// </summary>
        /// <value>The email identifier.</value>
        public int EmailID { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>The email address.</value>
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Email"/> is preferred.
        /// </summary>
        /// <value><c>true</c> if default; otherwise, <c>false</c>.</value>
        public bool Default { get; set; }
    }
}
