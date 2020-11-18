using CRM.IRepository;
using CRM.IServices.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Services
{

    public class BaseServices<TEntity> : IBaseServices<TEntity> where TEntity : class
    {
        //1.0 定义数据仓储的接口
        public IBaseRepository<TEntity> baseDal;

        #region query
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public async Task<List<TEntity>> QueryWhere(Expression<Func<TEntity, bool>> where)
        {
            return await baseDal.QueryWhere(where);
        }
        /// <summary>
        /// 连表查询
        /// </summary>
        /// <param name="where"></param>
        /// <param name="tableNames">表名集合</param>
        /// <returns></returns>
        public async Task<List<TEntity>> QueryJoin(Expression<Func<TEntity, bool>> where, string[] tableNames)
        {
            return await baseDal.QueryJoin(where, tableNames);
        }
        /// <summary>
        /// 查询排序
        /// </summary>
        /// <typeparam name="TKey">从TEntity中获取的属性类型</typeparam>
        /// <param name="where">查询条件表达式</param>
        /// <param name="order">排序表达式</param>
        /// <param name="OrderByType">排序类型，默认为升序</param>
        /// <returns></returns>
        public async Task<List<TEntity>> QueryOrderBy<TKey>(Expression<Func<TEntity, bool>> where,
            Expression<Func<TEntity, TKey>> order, bool OrderByType = false)
        {
            return await baseDal.QueryOrderBy<TKey>(where, order, OrderByType);
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <returns></returns>
        public async Task<Tuple<List<TEntity>, int>> QueryByPage<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> order, Expression<Func<TEntity, bool>> where)
        {
            return await baseDal.QueryByPage<TKey>(pageIndex,pageSize,order,where);
        }
        #endregion

        #region Edit
        public Task Edit(TEntity model, string[] propertys)
        {
            return baseDal.Edit(model, propertys);
        }
        #endregion

        #region Delete
        public Task Delete(TEntity model, bool isadded)
        {
            return baseDal.Delete(model, isadded);
        }
        #endregion

        public Task Add(TEntity model)
        {
            return baseDal.Add(model);
        }

        public async Task<int> SaveChanges()
        {
            return await baseDal.SaveChanges();
        }

        public async Task<List<TEntity>> QueryOrderByDescending<TKey>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TKey>> order)
        {
            return await baseDal.QueryOrderByDescending(where,order);
        }

        public async Task<List<TResult>> RunProc<TResult>(string sql, params object[] pamrs)
        {
            return await baseDal.RunProc<TResult>(sql, pamrs);
        }
    }
}
