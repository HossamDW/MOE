using MOEServices.Core.Result;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOEServices.Core.Interfaces
{
    public interface IUpdateForAsync<T, TKey> where T : class
    {
        Task<OperationResult> UpdateAsync(TKey key, T entityToUpdate);
    }
}
