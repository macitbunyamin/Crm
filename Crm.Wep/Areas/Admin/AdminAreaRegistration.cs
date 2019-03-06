﻿using System.Web.Mvc;

namespace Crm.Wep.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
               defaults: new { controller="Home", action = "Index", id = UrlParameter.Optional },
                namespaces:new[] {"Crm.Wep.Areas.Admin.Controllers"}

            );
        }
    }
}