//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM.Model.ModelViews
{
    using System;
    using System.Collections.Generic;
    
    using System.ComponentModel;
     using System.ComponentModel.DataAnnotations;
    public partial class sysPermissListView
    {
        public int plid { get; set; }
        public int rID { get; set; }
        public int mID { get; set; }
        public int fID { get; set; }
        public int plCreatorID { get; set; }
        public System.DateTime plCreateTime { get; set; }
    
        public virtual sysFunctionView sysFunction { get; set; }
        public virtual sysMenusView sysMenus { get; set; }
        public virtual sysRoleView sysRole { get; set; }
    }
}
