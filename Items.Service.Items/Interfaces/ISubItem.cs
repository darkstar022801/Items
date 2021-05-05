using Items.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Items.Service.Item.Interfaces
{
    public interface ISubItem
    {
        Task<Guid> CreateAsync(SubItemDTO subItemDTO);

        IAsyncEnumerable<SubItemDTO> GetAllAsync();

        IAsyncEnumerable<SubItemDTO> GetByIdAsync(Guid id);
    }
}
