using FCClassManagementSystem.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FCClassManagementSystem.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        public BaseController() { }

        private ApplicationDBContext _database;
        protected ApplicationDBContext Database
        {
            get
            {
                if (_database == null)
                    _database = new ApplicationDBContext();
                return _database;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (_database != null)
                _database.Dispose();
            base.Dispose(disposing);
        }
    }
}