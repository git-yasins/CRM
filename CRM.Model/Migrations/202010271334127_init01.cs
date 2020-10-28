namespace CRM.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sysFunctions",
                c => new
                    {
                        fID = c.Int(nullable: false, identity: true),
                        mID = c.Int(nullable: false),
                        fName = c.String(),
                        fFunction = c.String(),
                        fPicname = c.String(),
                        fStatus = c.Int(),
                        fCreatorID = c.Int(nullable: false),
                        fCreateTime = c.DateTime(nullable: false),
                        fUpdateID = c.Int(),
                        fUpdateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.fID)
                .ForeignKey("dbo.sysMenus", t => t.mID, cascadeDelete: true)
                .Index(t => t.mID);
            
            CreateTable(
                "dbo.sysMenus",
                c => new
                    {
                        mID = c.Int(nullable: false, identity: true),
                        mParentID = c.Int(nullable: false),
                        mName = c.String(),
                        mUrl = c.String(),
                        mArea = c.String(),
                        mController = c.String(),
                        mAction = c.String(),
                        mSortid = c.Int(nullable: false),
                        mStatus = c.Int(nullable: false),
                        mPicname = c.String(),
                        mLevel = c.Int(nullable: false),
                        mExp1 = c.String(),
                        mExp2 = c.Int(),
                        mCreatorID = c.Int(nullable: false),
                        mCreateTime = c.DateTime(nullable: false),
                        mUpdateID = c.Int(),
                        mUpdateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.mID);
            
            CreateTable(
                "dbo.sysPermissLists",
                c => new
                    {
                        plid = c.Int(nullable: false, identity: true),
                        rID = c.Int(nullable: false),
                        mID = c.Int(nullable: false),
                        fID = c.Int(nullable: false),
                        plCreatorID = c.Int(nullable: false),
                        plCreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.plid)
                .ForeignKey("dbo.sysFunctions", t => t.fID, cascadeDelete: true)
                .ForeignKey("dbo.sysMenus", t => t.mID)
                .ForeignKey("dbo.sysRoles", t => t.rID, cascadeDelete: true)
                .Index(t => t.rID)
                .Index(t => t.mID)
                .Index(t => t.fID);
            
            CreateTable(
                "dbo.sysRoles",
                c => new
                    {
                        rID = c.Int(nullable: false, identity: true),
                        eDepID = c.Int(),
                        RoleType = c.Int(nullable: false),
                        rName = c.String(),
                        rRemark = c.String(),
                        rSort = c.Int(nullable: false),
                        rStatus = c.Int(nullable: false),
                        rCreatorID = c.Int(nullable: false),
                        rCreateTime = c.DateTime(nullable: false),
                        rUpdateID = c.Int(),
                        rUpdateTime = c.DateTime(nullable: false),
                        sysOrganStruct_osID = c.Int(),
                        sysKeyValue_KID = c.Int(),
                    })
                .PrimaryKey(t => t.rID)
                .ForeignKey("dbo.sysOrganStructs", t => t.sysOrganStruct_osID)
                .ForeignKey("dbo.sysKeyValues", t => t.sysKeyValue_KID)
                .Index(t => t.sysOrganStruct_osID)
                .Index(t => t.sysKeyValue_KID);
            
            CreateTable(
                "dbo.sysKeyValues",
                c => new
                    {
                        KID = c.Int(nullable: false, identity: true),
                        ParentID = c.Int(nullable: false),
                        KType = c.Int(nullable: false),
                        KName = c.String(),
                        Kvalue = c.String(),
                        KRemark = c.String(),
                    })
                .PrimaryKey(t => t.KID);
            
            CreateTable(
                "dbo.sysOrganStructs",
                c => new
                    {
                        osID = c.Int(nullable: false, identity: true),
                        osParentID = c.Int(nullable: false),
                        osName = c.String(),
                        osCode = c.String(),
                        osCateID = c.Int(nullable: false),
                        osLevel = c.Int(),
                        osShortName = c.String(),
                        osRemark = c.String(),
                        osStatus = c.Int(),
                        osCreatorID = c.Int(),
                        osCreateTime = c.DateTime(nullable: false),
                        osUpdateID = c.Int(),
                        osUpdateTime = c.DateTime(nullable: false),
                        sysKeyValue_KID = c.Int(),
                    })
                .PrimaryKey(t => t.osID)
                .ForeignKey("dbo.sysKeyValues", t => t.sysKeyValue_KID)
                .Index(t => t.sysKeyValue_KID);
            
            CreateTable(
                "dbo.sysUserInfoes",
                c => new
                    {
                        uID = c.Int(nullable: false, identity: true),
                        uLoginName = c.String(),
                        uLoginPWD = c.String(),
                        uRealName = c.String(),
                        uTelphone = c.String(),
                        uMobile = c.String(),
                        uEmial = c.String(),
                        uQQ = c.String(),
                        uGender = c.Int(nullable: false),
                        uStatus = c.Int(nullable: false),
                        uCompanyID = c.Int(nullable: false),
                        uDepID = c.Int(),
                        uWorkGroupID = c.Int(),
                        uRemark = c.String(),
                        uCreatorID = c.Int(nullable: false),
                        uCreateTime = c.DateTime(nullable: false),
                        uUpdateID = c.Int(),
                        uUpdateTime = c.DateTime(nullable: false),
                        sysOrganStruct_osID = c.Int(),
                        sysOrganStruct1_osID = c.Int(),
                        sysOrganStruct2_osID = c.Int(),
                        sysOrganStruct_osID1 = c.Int(),
                        sysOrganStruct_osID2 = c.Int(),
                        sysOrganStruct_osID3 = c.Int(),
                    })
                .PrimaryKey(t => t.uID)
                .ForeignKey("dbo.sysOrganStructs", t => t.sysOrganStruct_osID)
                .ForeignKey("dbo.sysOrganStructs", t => t.sysOrganStruct1_osID)
                .ForeignKey("dbo.sysOrganStructs", t => t.sysOrganStruct2_osID)
                .ForeignKey("dbo.sysOrganStructs", t => t.sysOrganStruct_osID1)
                .ForeignKey("dbo.sysOrganStructs", t => t.sysOrganStruct_osID2)
                .ForeignKey("dbo.sysOrganStructs", t => t.sysOrganStruct_osID3)
                .Index(t => t.sysOrganStruct_osID)
                .Index(t => t.sysOrganStruct1_osID)
                .Index(t => t.sysOrganStruct2_osID)
                .Index(t => t.sysOrganStruct_osID1)
                .Index(t => t.sysOrganStruct_osID2)
                .Index(t => t.sysOrganStruct_osID3);
            
            CreateTable(
                "dbo.sysUserInfo_Role",
                c => new
                    {
                        urID = c.Int(nullable: false, identity: true),
                        uID = c.Int(nullable: false),
                        rID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.urID)
                .ForeignKey("dbo.sysRoles", t => t.rID, cascadeDelete: true)
                .ForeignKey("dbo.sysUserInfoes", t => t.uID, cascadeDelete: true)
                .Index(t => t.uID)
                .Index(t => t.rID);
            
            CreateTable(
                "dbo.wfRequestForms",
                c => new
                    {
                        wfRFID = c.Int(nullable: false, identity: true),
                        wfID = c.Int(nullable: false),
                        wfRFTitle = c.String(),
                        wfRFRemark = c.String(),
                        wfRFPriority = c.Int(nullable: false),
                        wfRFStatus = c.Int(nullable: false),
                        wfRFExt1 = c.String(),
                        wfRFExt2 = c.Int(),
                        wfRFLogicSymbol = c.String(),
                        wfRFNum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fCreatorID = c.Int(nullable: false),
                        fCreateTime = c.DateTime(nullable: false),
                        fUpdateTime = c.DateTime(),
                        sysKeyValue_KID = c.Int(),
                        sysKeyValue1_KID = c.Int(),
                        sysUserInfo_uID = c.Int(),
                        sysKeyValue_KID1 = c.Int(),
                        sysKeyValue_KID2 = c.Int(),
                    })
                .PrimaryKey(t => t.wfRFID)
                .ForeignKey("dbo.sysKeyValues", t => t.sysKeyValue_KID)
                .ForeignKey("dbo.sysKeyValues", t => t.sysKeyValue1_KID)
                .ForeignKey("dbo.sysUserInfoes", t => t.sysUserInfo_uID)
                .ForeignKey("dbo.wfWorks", t => t.wfID, cascadeDelete: true)
                .ForeignKey("dbo.sysKeyValues", t => t.sysKeyValue_KID1)
                .ForeignKey("dbo.sysKeyValues", t => t.sysKeyValue_KID2)
                .Index(t => t.wfID)
                .Index(t => t.sysKeyValue_KID)
                .Index(t => t.sysKeyValue1_KID)
                .Index(t => t.sysUserInfo_uID)
                .Index(t => t.sysKeyValue_KID1)
                .Index(t => t.sysKeyValue_KID2);
            
            CreateTable(
                "dbo.wfProcesses",
                c => new
                    {
                        wfPID = c.Int(nullable: false, identity: true),
                        wfRFID = c.Int(nullable: false),
                        wfProcessor = c.Int(nullable: false),
                        wfRFStatus = c.Int(nullable: false),
                        wfPDescription = c.String(),
                        wfnID = c.Int(nullable: false),
                        wfPExt1 = c.String(),
                        wfPExt2 = c.Int(),
                        fCreatorID = c.Int(nullable: false),
                        fCreateTime = c.DateTime(nullable: false),
                        fUpdateTime = c.DateTime(),
                        sysKeyValue_KID = c.Int(),
                    })
                .PrimaryKey(t => t.wfPID)
                .ForeignKey("dbo.sysKeyValues", t => t.sysKeyValue_KID)
                .ForeignKey("dbo.wfRequestForms", t => t.wfRFID, cascadeDelete: true)
                .ForeignKey("dbo.wfWorkNodes", t => t.wfnID, cascadeDelete: true)
                .Index(t => t.wfRFID)
                .Index(t => t.wfnID)
                .Index(t => t.sysKeyValue_KID);
            
            CreateTable(
                "dbo.wfWorkNodes",
                c => new
                    {
                        wfnID = c.Int(nullable: false, identity: true),
                        wfID = c.Int(nullable: false),
                        wfnOrderNo = c.Int(nullable: false),
                        wfNodeType = c.Int(nullable: false),
                        wfNodeTitle = c.String(),
                        wfnBizMethod = c.String(),
                        wfnMaxNum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        wfnRoleType = c.Int(nullable: false),
                        wfnExt1 = c.Int(),
                        wfnExt2 = c.String(),
                        fCreatorID = c.Int(nullable: false),
                        fCreateTime = c.DateTime(nullable: false),
                        fUpdateID = c.Int(),
                        fUpdateTime = c.DateTime(),
                        sysKeyValue_KID = c.Int(),
                        sysKeyValue1_KID = c.Int(),
                        sysKeyValue_KID1 = c.Int(),
                        sysKeyValue_KID2 = c.Int(),
                    })
                .PrimaryKey(t => t.wfnID)
                .ForeignKey("dbo.sysKeyValues", t => t.sysKeyValue_KID)
                .ForeignKey("dbo.sysKeyValues", t => t.sysKeyValue1_KID)
                .ForeignKey("dbo.wfWorks", t => t.wfID)
                .ForeignKey("dbo.sysKeyValues", t => t.sysKeyValue_KID1)
                .ForeignKey("dbo.sysKeyValues", t => t.sysKeyValue_KID2)
                .Index(t => t.wfID)
                .Index(t => t.sysKeyValue_KID)
                .Index(t => t.sysKeyValue1_KID)
                .Index(t => t.sysKeyValue_KID1)
                .Index(t => t.sysKeyValue_KID2);
            
            CreateTable(
                "dbo.wfWorks",
                c => new
                    {
                        wfID = c.Int(nullable: false, identity: true),
                        wfTitle = c.String(),
                        wfStatus = c.Int(nullable: false),
                        wfRemark = c.String(),
                        fCreatorID = c.Int(nullable: false),
                        fCreateTime = c.DateTime(nullable: false),
                        fUpdateID = c.Int(),
                        fUpdateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.wfID);
            
            CreateTable(
                "dbo.wfWorkBranches",
                c => new
                    {
                        wfbID = c.Int(nullable: false, identity: true),
                        wfnID = c.Int(nullable: false),
                        wfnToken = c.String(),
                        wfNodeID = c.Int(nullable: false),
                        fCreatorID = c.Int(nullable: false),
                        fCreateTime = c.DateTime(nullable: false),
                        fUpdateID = c.Int(),
                        fUpdateTime = c.DateTime(nullable: false),
                        wfWorkNodes_wfnID = c.Int(),
                        wfWorkNodes1_wfnID = c.Int(),
                        wfWorkNodes_wfnID1 = c.Int(),
                        wfWorkNodes_wfnID2 = c.Int(),
                    })
                .PrimaryKey(t => t.wfbID)
                .ForeignKey("dbo.wfWorkNodes", t => t.wfWorkNodes_wfnID)
                .ForeignKey("dbo.wfWorkNodes", t => t.wfWorkNodes1_wfnID)
                .ForeignKey("dbo.wfWorkNodes", t => t.wfWorkNodes_wfnID1)
                .ForeignKey("dbo.wfWorkNodes", t => t.wfWorkNodes_wfnID2)
                .Index(t => t.wfWorkNodes_wfnID)
                .Index(t => t.wfWorkNodes1_wfnID)
                .Index(t => t.wfWorkNodes_wfnID1)
                .Index(t => t.wfWorkNodes_wfnID2);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.sysPermissLists", "rID", "dbo.sysRoles");
            DropForeignKey("dbo.wfWorkNodes", "sysKeyValue_KID2", "dbo.sysKeyValues");
            DropForeignKey("dbo.wfWorkNodes", "sysKeyValue_KID1", "dbo.sysKeyValues");
            DropForeignKey("dbo.wfRequestForms", "sysKeyValue_KID2", "dbo.sysKeyValues");
            DropForeignKey("dbo.wfRequestForms", "sysKeyValue_KID1", "dbo.sysKeyValues");
            DropForeignKey("dbo.sysRoles", "sysKeyValue_KID", "dbo.sysKeyValues");
            DropForeignKey("dbo.sysUserInfoes", "sysOrganStruct_osID3", "dbo.sysOrganStructs");
            DropForeignKey("dbo.sysUserInfoes", "sysOrganStruct_osID2", "dbo.sysOrganStructs");
            DropForeignKey("dbo.sysUserInfoes", "sysOrganStruct_osID1", "dbo.sysOrganStructs");
            DropForeignKey("dbo.wfWorkBranches", "wfWorkNodes_wfnID2", "dbo.wfWorkNodes");
            DropForeignKey("dbo.wfWorkBranches", "wfWorkNodes_wfnID1", "dbo.wfWorkNodes");
            DropForeignKey("dbo.wfWorkBranches", "wfWorkNodes1_wfnID", "dbo.wfWorkNodes");
            DropForeignKey("dbo.wfWorkBranches", "wfWorkNodes_wfnID", "dbo.wfWorkNodes");
            DropForeignKey("dbo.wfWorkNodes", "wfID", "dbo.wfWorks");
            DropForeignKey("dbo.wfRequestForms", "wfID", "dbo.wfWorks");
            DropForeignKey("dbo.wfProcesses", "wfnID", "dbo.wfWorkNodes");
            DropForeignKey("dbo.wfWorkNodes", "sysKeyValue1_KID", "dbo.sysKeyValues");
            DropForeignKey("dbo.wfWorkNodes", "sysKeyValue_KID", "dbo.sysKeyValues");
            DropForeignKey("dbo.wfProcesses", "wfRFID", "dbo.wfRequestForms");
            DropForeignKey("dbo.wfProcesses", "sysKeyValue_KID", "dbo.sysKeyValues");
            DropForeignKey("dbo.wfRequestForms", "sysUserInfo_uID", "dbo.sysUserInfoes");
            DropForeignKey("dbo.wfRequestForms", "sysKeyValue1_KID", "dbo.sysKeyValues");
            DropForeignKey("dbo.wfRequestForms", "sysKeyValue_KID", "dbo.sysKeyValues");
            DropForeignKey("dbo.sysUserInfo_Role", "uID", "dbo.sysUserInfoes");
            DropForeignKey("dbo.sysUserInfo_Role", "rID", "dbo.sysRoles");
            DropForeignKey("dbo.sysUserInfoes", "sysOrganStruct2_osID", "dbo.sysOrganStructs");
            DropForeignKey("dbo.sysUserInfoes", "sysOrganStruct1_osID", "dbo.sysOrganStructs");
            DropForeignKey("dbo.sysUserInfoes", "sysOrganStruct_osID", "dbo.sysOrganStructs");
            DropForeignKey("dbo.sysRoles", "sysOrganStruct_osID", "dbo.sysOrganStructs");
            DropForeignKey("dbo.sysOrganStructs", "sysKeyValue_KID", "dbo.sysKeyValues");
            DropForeignKey("dbo.sysPermissLists", "mID", "dbo.sysMenus");
            DropForeignKey("dbo.sysPermissLists", "fID", "dbo.sysFunctions");
            DropForeignKey("dbo.sysFunctions", "mID", "dbo.sysMenus");
            DropIndex("dbo.wfWorkBranches", new[] { "wfWorkNodes_wfnID2" });
            DropIndex("dbo.wfWorkBranches", new[] { "wfWorkNodes_wfnID1" });
            DropIndex("dbo.wfWorkBranches", new[] { "wfWorkNodes1_wfnID" });
            DropIndex("dbo.wfWorkBranches", new[] { "wfWorkNodes_wfnID" });
            DropIndex("dbo.wfWorkNodes", new[] { "sysKeyValue_KID2" });
            DropIndex("dbo.wfWorkNodes", new[] { "sysKeyValue_KID1" });
            DropIndex("dbo.wfWorkNodes", new[] { "sysKeyValue1_KID" });
            DropIndex("dbo.wfWorkNodes", new[] { "sysKeyValue_KID" });
            DropIndex("dbo.wfWorkNodes", new[] { "wfID" });
            DropIndex("dbo.wfProcesses", new[] { "sysKeyValue_KID" });
            DropIndex("dbo.wfProcesses", new[] { "wfnID" });
            DropIndex("dbo.wfProcesses", new[] { "wfRFID" });
            DropIndex("dbo.wfRequestForms", new[] { "sysKeyValue_KID2" });
            DropIndex("dbo.wfRequestForms", new[] { "sysKeyValue_KID1" });
            DropIndex("dbo.wfRequestForms", new[] { "sysUserInfo_uID" });
            DropIndex("dbo.wfRequestForms", new[] { "sysKeyValue1_KID" });
            DropIndex("dbo.wfRequestForms", new[] { "sysKeyValue_KID" });
            DropIndex("dbo.wfRequestForms", new[] { "wfID" });
            DropIndex("dbo.sysUserInfo_Role", new[] { "rID" });
            DropIndex("dbo.sysUserInfo_Role", new[] { "uID" });
            DropIndex("dbo.sysUserInfoes", new[] { "sysOrganStruct_osID3" });
            DropIndex("dbo.sysUserInfoes", new[] { "sysOrganStruct_osID2" });
            DropIndex("dbo.sysUserInfoes", new[] { "sysOrganStruct_osID1" });
            DropIndex("dbo.sysUserInfoes", new[] { "sysOrganStruct2_osID" });
            DropIndex("dbo.sysUserInfoes", new[] { "sysOrganStruct1_osID" });
            DropIndex("dbo.sysUserInfoes", new[] { "sysOrganStruct_osID" });
            DropIndex("dbo.sysOrganStructs", new[] { "sysKeyValue_KID" });
            DropIndex("dbo.sysRoles", new[] { "sysKeyValue_KID" });
            DropIndex("dbo.sysRoles", new[] { "sysOrganStruct_osID" });
            DropIndex("dbo.sysPermissLists", new[] { "fID" });
            DropIndex("dbo.sysPermissLists", new[] { "mID" });
            DropIndex("dbo.sysPermissLists", new[] { "rID" });
            DropIndex("dbo.sysFunctions", new[] { "mID" });
            DropTable("dbo.wfWorkBranches");
            DropTable("dbo.wfWorks");
            DropTable("dbo.wfWorkNodes");
            DropTable("dbo.wfProcesses");
            DropTable("dbo.wfRequestForms");
            DropTable("dbo.sysUserInfo_Role");
            DropTable("dbo.sysUserInfoes");
            DropTable("dbo.sysOrganStructs");
            DropTable("dbo.sysKeyValues");
            DropTable("dbo.sysRoles");
            DropTable("dbo.sysPermissLists");
            DropTable("dbo.sysMenus");
            DropTable("dbo.sysFunctions");
        }
    }
}
