// ***********************************************************************
// Assembly         : CommonCore
// Author           : John Reasor
// Created          : 07-05-2017
//
// Last Modified By : John Reasor
// Last Modified On : 07-05-2017
// ***********************************************************************
// <copyright file="WaitStaff.cs" company="J&S Software, LLC">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.Models.WaitStaff
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Employees;

    using Stations;

    /// <summary>
    /// Class WaitStaff.
    /// </summary>
    /// <seealso cref="CommonCore.Models.Employees.Employee" />
    public class WaitStaff : Employee
    {
        /// <summary>
        /// Gets or sets the stations.
        /// </summary>
        /// <value>The stations.</value>
        public ICollection<Station> Stations { get; set; }
    }
}
