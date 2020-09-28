using MOEServices.Core.Result;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOEServices.Core.Interfaces
{
    public interface IDeleteForAsync<TKey>
    {
        Task<OperationResult> DeleteAsync(TKey key);
    }
}
