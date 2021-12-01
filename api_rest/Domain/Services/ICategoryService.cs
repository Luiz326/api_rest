using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest.Domain.Model;


namespace api_rest.Domain.Services
{
    interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
