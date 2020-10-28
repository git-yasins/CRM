using CRM.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Model
{
    class CRMDbContext : DbContext
    {
        public CRMDbContext() : base("name=sqlConnStr") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<sysPermissList>().HasRequired(a => a.sysMenus).WithMany(u => u.sysPermissList).WillCascadeOnDelete(false);
            modelBuilder.Entity<wfWorkNodes>().HasRequired(a => a.wfWork).WithMany(u => u.wfWorkNodes).WillCascadeOnDelete(false);

        }
        public DbSet<sysFunction> sysFunctions { get; set; }
        public DbSet<sysKeyValue> sysKeyValues { get; set; }
        public DbSet<sysMenus> sysMenus { get; set; }
        public DbSet<sysOrganStruct> sysOrganStructs { get; set; }
        public DbSet<sysPermissList> sysPermissLists { get; set; }
        public DbSet<sysRole> sysRoles { get; set; }
        public DbSet<sysUserInfo> sysUserInfos { get; set; }
        public DbSet<sysUserInfo_Role> sysUserInfo_Roles { get; set; }
        // public DbSet<Usp_GetFunctionsForUser15_Result> Usp_GetFunctionsForUser15_Results { get; set; }
        public DbSet<wfProcess> WfProcess { get; set; }
        public DbSet<wfRequestForm> wfRequestForms { get; set; }
        public DbSet<wfWork> wfWorks { get; set; }
        public DbSet<wfWorkBranch> wfWorkBranchs { get; set; }
        public DbSet<wfWorkNodes> wfWorkNodes { get; set; }
    }
}
