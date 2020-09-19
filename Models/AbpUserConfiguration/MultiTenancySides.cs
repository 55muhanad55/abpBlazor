using System;

namespace Web.Blazor.Models.AbpUserConfiguration
{
    [Flags]
    public enum MultiTenancySides
    {
        /// <summary>
        /// Tenant side.
        /// </summary>
        Tenant = 1,

        /// <summary>
        /// Host (tenancy owner) side.
        /// </summary>
        Host = 2
    }
}
