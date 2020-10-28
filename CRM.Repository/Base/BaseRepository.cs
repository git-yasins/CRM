using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CRM.Repository
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        BaseDBContext db = new BaseDBContext();
        DbSet<TEntity> _dbset;

        public BaseRepository()
        {
            _dbset = db.Set<TEntity>();
        }

        #region query
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public async Task<List<TEntity>> QueryWhere(Expression<Func<TEntity, bool>> where)
        {
            return await _dbset.Where(where).ToListAsync();
        }
        /// <summary>
        /// 连表查询
        /// </summary>
        /// <param name="where"></param>
        /// <param name="tableNames">表名集合</param>
        /// <returns></returns>
        public async Task<List<TEntity>> QueryJoin(Expression<Func<TEntity, bool>> where, string[] tableNames)
        {
            if (tableNames == null || !tableNames.Any())
            {
                throw new Exception("连表操作的表名称至少要有一个");
            }

            DbQuery<TEntity> query = _dbset;
            foreach (var tableName in tableNames)
            {
                query = query.Include(tableName);
            }

            return await query.Where(where).ToListAsync();
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
            return OrderByType
                ? await _dbset.Where(where).OrderBy(order).ToListAsync() :
                await _dbset.Where(where).OrderByDescending(order).ToListAsync();
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <returns></returns>
        public async Task<Tuple<List<TEntity>, int>> QueryByPage<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> order, Expression<Func<TEntity, bool>> where)
        {
            int skipCount = (pageIndex - 1) * pageSize;
            int rowCount = await _dbset.Where(where).CountAsync();
            List<TEntity> list = await _dbset.Where(where).OrderByDescending(order).Skip(skipCount).Take(pageSize).ToListAsync();
            Tuple<List<TEntity>, int> tuple = new Tuple<List<TEntity>, int>(list, rowCount);
            return tuple;
        }
        #endregion

        #region Edit
        public Task Edit(TEntity model, string[] propertys)
        {
            if (model == null)
            {
                throw new Exception("实体不能为空");
            }

            if (!propertys.Any())
            {
                throw new Exception("要修改的属性至少要有一个");
            }

            DbEntityEntry entry = db.Entry(model);
            entry.State = EntityState.Unchanged;

            foreach (var item in propertys)
            {
                entry.Property(item).IsModified = true;
            }
            //关闭EF对实体的合法性验证参数
            db.Configuration.ValidateOnSaveEnabled = false;

            return Task.CompletedTask;
        }
        #endregion

        #region Delete
        public Task Delete(TEntity model,bool isadded)
        {
            //如果model没有追加到容器
            if (!isadded)
            {
                _dbset.Attach(model);
            }

            _dbset.Remove(model);
            return Task.CompletedTask;
        }
        #endregion

        public Task Add(TEntity model)
        {
            _dbset.Add(model);
            return Task.CompletedTask;
        }

        public async Task<int> SaveChanges()
        {
            return await db.SaveChangesAsync();
        }

        public Task<List<TEntity>> QueryByPage<TKey>(int pageindex, int pagesize, out int rowcount, Expression<Func<TEntity, TKey>> order, Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> QueryOrderBy<TKey>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TKey>> order)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> QueryOrderByDescending<TKey>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TKey>> order)
        {
            throw new NotImplementedException();
        }

        public Task<List<TResult>> RunProc<TResult>(string sql, params object[] pamrs)
        {
            throw new NotImplementedException();
        }
    }
}
