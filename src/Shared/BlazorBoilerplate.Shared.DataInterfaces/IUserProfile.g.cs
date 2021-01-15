//Autogenerated by BlazorBoilerplate.EntityGenerator
using BlazorBoilerplate.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BlazorBoilerplate.Shared.DataInterfaces
{
    public interface IUserProfile
    {
        Int64 Id { get; set; }

        Guid UserId { get; set; }

        IApplicationUser ApplicationUser { get; set; }

        String LastPageVisited { get; set; }

        Boolean IsNavOpen { get; set; }

        Boolean IsNavMinified { get; set; }

        Int32 Count { get; set; }

        DateTime LastUpdatedDate { get; set; }

        String TenantId { get; set; }

    }
}