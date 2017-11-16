using FCCClassManagementSystem.Domain.Entities;
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
    public class AppUserManager : UserManager<User>
    {
        public AppUserManager(IUserStore<User> store) : base(store)
        {
        }
        public static AppUserManager Create(IdentityFactoryOptions<AppUserManager> options, IOwinContext context)
        {
            ApplicationDBContext db = context.Get<ApplicationDBContext>();
            AppUserManager manager = new AppUserManager(new UserStore<User>(db));

            manager.UserValidator = new UserValidator<User>(manager)
            {
                AllowOnlyAlphanumericUserNames = true,
                RequireUniqueEmail = true
            };

            return manager;
        }
    }
}