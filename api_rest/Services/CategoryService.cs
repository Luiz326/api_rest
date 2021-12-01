using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest.Domain.Models;
using api_rest.Domain.Services;
using api_rest.Domain.Repositories;

namespace api_rest.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
