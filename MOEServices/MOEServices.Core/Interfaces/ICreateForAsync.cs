using MOEServices.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOEServices.Core.Interfaces
{
    public interface ICreateForAsync<T> where T : class
    {
        Task<OperationResult> CreateAsync(T entityToCreate);
    }
}
