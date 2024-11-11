using AngleSharp.Dom;
using DataTransferObject.DTOClasses;
using Infrastructure.RepositoryPattern;
using Mapster;
using Microsoft.EntityFrameworkCore;
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
        private readonly IBaseRepository<Category, Guid> _categoryrepository;

        public CategoryService(IBaseRepository<Category,Guid> categoryrepository)
        {
            _categoryrepository = categoryrepository;
        }
        public async Task<Category> CreateCategory(CategoryDTO categorydto)
        {
            var entity = TranslateToEntity(categorydto);
            return await _categoryrepository.CreateDataAsync(entity); 

        }

    public async Task<List<CategoryDTO>> GetAllCategory()
        {
           var categories = await _categoryrepository.GetAllAsync();
           var categoriesdto=categories.ProjectToType<CategoryDTO>().ToList();
          // List<CategoryDTO> result = new List<CategoryDTO>();
          //foreach (var category in categories)
          //  {

          //      result.Add(category.Adapt<CategoryDTO>());
          //  }
          // categories
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
