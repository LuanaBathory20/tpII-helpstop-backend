using AutoMapper;
using HelpApp.Application.Itr;
using HelpApp.Domain.Interfaces;

namespace HelpApp.Application.Services
{
    public class CategoryServices : ICategoryServicss
    {
        private readonly ICategoryRepository ICategoryRepository;
        private readonly IMapper mapper;
        public ICategoryServices(ICategoryRepository ICategoryRepository, IMapper mapper) 
        { 
        
        }
    }
}
