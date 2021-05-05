using Items.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Items.Service.Item.Interfaces
{
    public interface ICategory
    {
        Task<Guid> CreateAsync(CategoryDTO categoryDTO);

        IAsyncEnumerable<CategoryDTO> GetAllAsync();

        Task<CategoryDTO> GetByIdAsync(Guid id);
    }
}
