using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rest.Domain.Repositories
{
    interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
