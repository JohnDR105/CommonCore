// ***********************************************************************
// Assembly         : CommonCore
// Author           : John Reasor
// Created          : 07-05-2017
//
// Last Modified By : John Reasor
// Last Modified On : 07-05-2017
// ***********************************************************************
// <copyright file="Phone.cs" company="J&S Software, LLC">
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
    /// Class Phone.
    /// </summary>
    public class Phone
    {
        /// <summary>
        /// Gets or sets the phone identifier.
        /// </summary>
        /// <value>The phone identifier.</value>
        public int PhoneID { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>The number.</value>
        [Required(ErrorMessage = "Mobile no. is required")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Email"/> is preferred.
        /// </summary>
        /// <value><c>true</c> if default; otherwise, <c>false</c>.</value>
        public bool Default { get; set; }
    }
}
