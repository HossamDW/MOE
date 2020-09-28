using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOEServices.Core.Interfaces
{
    public interface IFindForAsync<TResult, TKey> where TResult : class
    {
        Task<TResult> FindAsync(TKey key);
    }
}
