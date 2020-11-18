using CRM.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace CRM.WebHelper
{
    public class BaseController : Controller
    {
        protected IsysFunctionServices isysFunctionServices;
        protected IsysKeyValueServices isysKeyValueServices;
        protected IsysMenusServices isysMenusServices;
        protected IsysOrganStructServices isysOrganStructServices;
        protected IsysPermissListServices isysPermissListServices;
        protected IsysRoleServices isysRoleServices;
        protected IsysUserInfoServices isysUserInfoServices;
        protected IsysUserInfo_RoleServices isysUserInfo_RoleServices;
        protected IwfProcessServices iwfProcessServices;
        protected IwfRequestFormServices iwfRequestFormServices;
        protected IwfWorkServices iwfWorkServices;
        protected IwfWorkBranchServices iwfWorkBranchServices;
        protected IwfWorkNodesServices iwfWorkNodesServices;
    }
}
