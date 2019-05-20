using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessInterface
{
    public interface IBaseService:IDisposable
    {
        T Insert<T>(T t) where T : class;
    }
}
