using System.Collections.Generic;
using System.Threading.Tasks;
using HelpApp.Application.DTOs;

namespace HelpApp.Application.Itr
{
    public interface ICategoryServicss
    {
        Task<IEnumerable<CategoryDTO>> GetAllCategories();
        Task<CategoryDTO> GetById(int? id);
        Task Add (CategoryDTO categoryDto);
        Task Update(CategoryDTO categoryDto);
        Task Remove (int id);
    }
}
