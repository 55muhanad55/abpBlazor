using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Blazor.Models.AbpUserConfiguration
{
    public class UserMenu
    {
        public string Name { get; set; }

        /// <summary>
        /// Display name of the menu.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// A custom object related to this menu item.
        /// </summary>
        public object CustomData { get; set; }

        /// <summary>
        /// Menu items (first level).
        /// </summary>
        public IList<UserMenuItem> Items { get; set; }



    }
}
