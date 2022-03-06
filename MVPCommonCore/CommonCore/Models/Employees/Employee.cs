// ***********************************************************************
// Assembly         : CommonCore
// Author           : John Reasor
// Created          : 07-05-2017
//
// Last Modified By : John Reasor
// Last Modified On : 07-05-2017
// ***********************************************************************
// <copyright file="Employee.cs" company="J&S Software, LLC">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.Models.Employees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Persons;

    /// <summary>
    /// Class Employee.
    /// </summary>
    /// <seealso cref="CommonCore.Models.Persons.Person" />
    public class Employee : Person
    {
        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>The employee identifier.</value>
        public int EmployeeID { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether this instance can receive tips.
        /// </summary>
        /// <value><c>true</c> if this instance can receive tips; otherwise, <c>false</c>.</value>
        public bool CanReceiveTips { get; set; }

        /// <summary>
        /// Gets or sets the employee type enums.
        /// </summary>
        /// <value>The employee type enums.</value>
        public virtual ICollection<EmployeeType> EmployeeTypeEnums { get; set; }

        /// <summary>
        /// Gets or sets the employees.
        /// </summary>
        /// <value>The employees.</value>
        public virtual ICollection<Employee> Employees { get; set; }

    }
}
