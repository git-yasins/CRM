using CRM.IServices;
using CRM.Model.ModelViews;
using CRM.WebHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Web.Areas.Admin.Controllers
{
    public class LoginController : BaseController
    {
        public LoginController(IsysUserInfoServices isysUserInfoService, IsysFunctionServices isysFunctionServices)
        {
            base.isysUserInfoServices = isysUserInfoService ?? throw new ArgumentNullException(nameof(IsysUserInfoServices));
            base.isysFunctionServices = isysFunctionServices ?? throw new ArgumentNullException(nameof(IsysFunctionServices));
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginInfo model)
        {
            return View();
        }
    }
}