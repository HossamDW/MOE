using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MOEServices.Core.Interfaces
{
    public interface IGetAllFor<TResult> where TResult : class
    {
        IQueryable<TResult> GetAll();
    }
}
