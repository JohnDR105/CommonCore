// ***********************************************************************
// Assembly         : CommonCore
// Author           : John Reasor
// Created          : 07-05-2017
//
// Last Modified By : John Reasor
// Last Modified On : 07-05-2017
// ***********************************************************************
// <copyright file="Station.cs" company="J&S Software, LLC">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.Models.Stations
{
    using System;
    using System.Linq;

    /// <summary>
    /// Class Station.
    /// </summary>
    public class Station
    {
        /// <summary>
        /// Gets or sets the station identifier.
        /// </summary>
        /// <value>The station identifier.</value>
        public int StationID { get; set; }

        /// <summary>
        /// Gets or sets the seat count.
        /// </summary>
        /// <value>The seat count.</value>
        public int SeatCount { get; set; }
    }
}
