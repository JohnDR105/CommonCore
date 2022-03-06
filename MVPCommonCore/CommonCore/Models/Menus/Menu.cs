// ***********************************************************************
// Assembly         : CommonCore
// Author           : John Reasor
// Created          : 08-02-2017
//
// Last Modified By : John Reasor
// Last Modified On : 08-02-2017
// ***********************************************************************
// <copyright file="Menu.cs" company="J&S Software, LLC">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace CommonCore.Models.Menus
{
    using System;
    using System.Linq;

    public class Menu
    {
        public int MenuID { get; set; }

        public MenuTypes MenuType { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }


    }
}
