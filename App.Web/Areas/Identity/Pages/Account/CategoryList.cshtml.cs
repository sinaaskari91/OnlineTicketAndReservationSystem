using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model.Entities;
using Service.ServiceInterfaces;

namespace App.Web.Areas.Identity.Pages.Account
{
    public class CategoryListModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<AddCategoryModel> _logger;
        private readonly ICategoryService _categoryservice;
        public CategoryListModel(ICategoryService categoryservice, SignInManager<User> signInManager, ILogger<AddCategoryModel> logger)
        {
            _categoryservice = categoryservice;
            _signInManager = signInManager;
            _logger = logger;

        }
       
        public void OnGet()
        {

            _categoryservice.GetAllCategory();

        }
        public void OnPost() 
        {
            Page();
        }
    }
}
