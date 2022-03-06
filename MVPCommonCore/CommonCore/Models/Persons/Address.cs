// ***********************************************************************
// Assembly         : CommonCore
// Author           : John Reasor
// Created          : 07-05-2017
//
// Last Modified By : John Reasor
// Last Modified On : 07-05-2017
// ***********************************************************************
// <copyright file="Address.cs" company="J&S Software, LLC">
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
    /// Class Address.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the address identifier.
        /// </summary>
        /// <value>The address identifier.</value>
        public int AddressID { get; set; }

        /// <summary>
        /// Gets or sets the street1.
        /// </summary>
        /// <value>The street1.</value>
        public string Street1 { get; set; }

        /// <summary>
        /// Gets or sets the street2.
        /// </summary>
        /// <value>The street2.</value>
        public string Street2 { get; set; }

        /// <summary>
        /// Gets or sets the unit.
        /// </summary>
        /// <value>The unit.</value>
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        /// <value>The zip.</value>
        [RegularExpression(@"(^\d{5}(-\d{4})?$)|(^[ABCEGHJKLMNPRSTVXYabceghjklmnprstvxy]{1}\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstv‌​xy]{1} *\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstvxy]{1}\d{1}$)", ErrorMessage = "That postal code is not a valid US or Canadian postal code.")]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Address"/> is current.
        /// </summary>
        /// <value><c>true</c> if current; otherwise, <c>false</c>.</value>
        public bool Current { get; set; }
    }
}
