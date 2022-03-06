// ***********************************************************************
// Assembly         : CommonCore
// Author           : John Reasor
// Created          : 07-06-2017
//
// Last Modified By : John Reasor
// Last Modified On : 07-06-2017
// ***********************************************************************
// <copyright file="EmployeeType.cs" company="J&S Software, LLC">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.Models.Employees
{
    using System;
    using System.Linq;

    /// <summary>
    /// Class EmployeeType.
    /// </summary>
    public class EmployeeType
    {
        /// <summary>
        /// Gets or sets the employee type identifier.
        /// </summary>
        /// <value>The employee type identifier.</value>
        public int EmployeeTypeID { get; set; }

        /// <summary>
        /// Gets or sets the employee type enum.
        /// </summary>
        /// <value>The employee type enum.</value>
        public EmployeeTypeEnum EmployeeTypeEnum { get; set; }
    }
}
