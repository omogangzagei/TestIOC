using BussinessInterface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFModel;

namespace BussinessServer
{
    public class BaseServic : IBaseService
    {
        protected DbContext dbContext { get; private set; }

        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="db"></param>
        public BaseServic(DbContext db)
        {
            this.dbContext = db;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public T Insert<T>(T t) where T : class
        {
            dbContext.Set<T>().Add(t);
            this.Commit();
            return t;
        }

        /// <summary>
        /// 提交
        /// </summary>
        public void Commit()
        {
            this.dbContext.SaveChanges();
        }
    }
}
