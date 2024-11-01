using AngleSharp.Dom;
using DataTransferObject.DTOClasses;
using Infrastructure.RepositoryPattern;
using Mapster;
using Model.Entities;
using Service.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service.ServiceClasses
{
    public class CategoryService : ICategoryService
    {
        private readonly IBaseRepository<Category, Guid> _repository;

        public CategoryService(IBaseRepository<Category,Guid> repository)
        {
            _repository = repository;
        }
        public async Task<Category> CreateCategory(CategoryDTO categorydto)
        {
            var entity = TranslateToEntity(categorydto);
            return await _repository.CreateDataAsync(entity); 

        }

    public async Task<List<CategoryDTO>> GetAllCategory()
        {
           var categories=await _repository.GetAllAsync();
            var categoriesdto=categories.ProjectToType<CategoryDTO>().ToList();
            return categoriesdto;
        }

        public CategoryDTO TranslateToDTO(Category entity)
        {
           return entity.Adapt<CategoryDTO>();
        }

        public Category TranslateToEntity(CategoryDTO dto)
        {
            return dto.Adapt<Category>();
        }

       
    }
}
