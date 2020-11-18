namespace itcast.CRM15.EntityMapping
{
    using AutoMapper;
    using CRM.Model;
    using CRM.Model.ModelViews;


    public static class EntityMapper
    {
        static MapperConfiguration configuration = null;
        static IMapper mapper = null;
        
        /// <summary>
        /// 负责将所有实体做一次映射操作
        /// </summary>
        static EntityMapper()
        {
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<sysFunction, sysFunctionView>();
                cfg.CreateMap<sysKeyValue, sysKeyValueView>();
                cfg.CreateMap<sysMenus, sysMenusView>();
                cfg.CreateMap<sysOrganStruct, sysOrganStructView>();
                cfg.CreateMap<sysPermissList, sysPermissListView>();
                cfg.CreateMap<sysRole, sysRoleView>();
                cfg.CreateMap<sysUserInfo, sysUserInfoView>();
                cfg.CreateMap<sysUserInfo_Role, sysUserInfo_RoleView>();
                cfg.CreateMap<wfProcess, wfProcessView>();
                cfg.CreateMap<wfRequestForm, wfRequestFormView>();
                cfg.CreateMap<wfWork, wfWorkView>();
                cfg.CreateMap<wfWorkBranch, wfWorkBranchView>();
                cfg.CreateMap<wfWorkNodes, wfWorkNodesView>();

                cfg.CreateMap<sysFunctionView, sysFunction>();
                cfg.CreateMap<sysKeyValueView, sysKeyValue>();
                cfg.CreateMap<sysMenusView, sysMenus>();
                cfg.CreateMap<sysOrganStructView, sysOrganStruct>();
                cfg.CreateMap<sysPermissListView, sysPermissList>();
                cfg.CreateMap<sysRoleView, sysRole>();
                cfg.CreateMap<sysUserInfoView, sysUserInfo>();
                cfg.CreateMap<sysUserInfo_RoleView, sysUserInfo_Role>();
                cfg.CreateMap<wfProcessView, wfProcess>();
                cfg.CreateMap<wfRequestFormView, wfRequestForm>();
                cfg.CreateMap<wfWorkView, wfWork>();
                cfg.CreateMap<wfWorkBranchView, wfWorkBranch>();
                cfg.CreateMap<wfWorkNodesView, wfWorkNodes>();
            });

            mapper = configuration.CreateMapper();
        }

        //3.0 生成所有的实体的两个转换扩展方法

        public static sysFunctionView EntityMap(this sysFunction model)
        {
            //2.0 将一个实体转换成另外一个实体
             return mapper.Map<sysFunction, sysFunctionView>(model);
        }

        public static sysFunction EntityMap(this sysFunctionView model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<sysFunctionView, sysFunction>(model);
        }

        public static sysKeyValueView EntityMap(this sysKeyValue model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<sysKeyValue, sysKeyValueView>(model);
        }

        public static sysKeyValue EntityMap(this sysKeyValueView model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<sysKeyValueView, sysKeyValue>(model);
        }

        public static sysMenusView EntityMap(this sysMenus model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<sysMenus, sysMenusView>(model);
        }

        public static sysMenus EntityMap(this sysMenusView model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<sysMenusView, sysMenus>(model);
        }

        public static sysOrganStructView EntityMap(this sysOrganStruct model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<sysOrganStruct, sysOrganStructView>(model);
        }

        public static sysOrganStruct EntityMap(this sysOrganStructView model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<sysOrganStructView, sysOrganStruct>(model);
        }

        public static sysPermissListView EntityMap(this sysPermissList model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<sysPermissList, sysPermissListView>(model);
        }

        public static sysPermissList EntityMap(this sysPermissListView model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<sysPermissListView, sysPermissList>(model);
        }

        public static sysRoleView EntityMap(this sysRole model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<sysRole, sysRoleView>(model);
        }

        public static sysRole EntityMap(this sysRoleView model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<sysRoleView, sysRole>(model);
        }

        public static sysUserInfoView EntityMap(this sysUserInfo model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<sysUserInfo, sysUserInfoView>(model);
        }

        public static sysUserInfo EntityMap(this sysUserInfoView model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<sysUserInfoView, sysUserInfo>(model);
        }

        public static sysUserInfo_RoleView EntityMap(this sysUserInfo_Role model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<sysUserInfo_Role, sysUserInfo_RoleView>(model);
        }

        public static sysUserInfo_Role EntityMap(this sysUserInfo_RoleView model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<sysUserInfo_RoleView, sysUserInfo_Role>(model);
        }

        public static wfProcessView EntityMap(this wfProcess model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<wfProcess, wfProcessView>(model);
        }

        public static wfProcess EntityMap(this wfProcessView model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<wfProcessView, wfProcess>(model);
        }

        public static wfRequestFormView EntityMap(this wfRequestForm model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<wfRequestForm, wfRequestFormView>(model);
        }

        public static wfRequestForm EntityMap(this wfRequestFormView model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<wfRequestFormView, wfRequestForm>(model);
        }

        public static wfWorkView EntityMap(this wfWork model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<wfWork, wfWorkView>(model);
        }

        public static wfWork EntityMap(this wfWorkView model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<wfWorkView, wfWork>(model);
        }

        public static wfWorkBranchView EntityMap(this wfWorkBranch model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<wfWorkBranch, wfWorkBranchView>(model);
        }

        public static wfWorkBranch EntityMap(this wfWorkBranchView model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<wfWorkBranchView, wfWorkBranch>(model);
        }

        public static wfWorkNodesView EntityMap(this wfWorkNodes model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<wfWorkNodes, wfWorkNodesView>(model);
        }

        public static wfWorkNodes EntityMap(this wfWorkNodesView model)
        {
            //2.0 将一个实体转换成另外一个实体
            return mapper.Map<wfWorkNodesView, wfWorkNodes>(model);
        }
    }
}
