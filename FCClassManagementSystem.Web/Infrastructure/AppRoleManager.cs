﻿using FCCClassManagementSystem.Domain.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FCClassManagementSystem.Web.Infrastructure
{
    public class AppRoleManager : RoleManager<Role>, IDisposable
    {
        public AppRoleManager(RoleStore<Role> store) : base(store)
        {
        }

        public static AppRoleManager Create(IdentityFactoryOptions<AppRoleManager> options, IOwinContext context)
        {
            return new AppRoleManager(new RoleStore<Role>(context.Get<ApplicationDBContext>()));
        }
    }
}