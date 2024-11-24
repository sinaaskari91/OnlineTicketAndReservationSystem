using DataTransferObject.DTOClasses;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model.Entities;
using Service.ServiceClasses;
using Service.ServiceInterfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Web.Areas.Identity.Pages.Account
{
    public class AddCategoryModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<AddCategoryModel> _logger;
        private readonly ICategoryService _categoryservice;
        public AddCategoryModel(ICategoryService categoryservice, SignInManager<User> signInManager, ILogger<AddCategoryModel> logger)
        {
            _categoryservice = categoryservice;
            _signInManager = signInManager;
            _logger = logger;

        }
        [BindProperty]
        public CategoryDTO Input { get; set; }


        public IActionResult OnGetAsync()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            //var result=  await _categoryservice.CreateCategory(Input);
            //return RedirectToPage("categorylist");
            if (ModelState.IsValid)
            {

                Input.UpdatedDateTime = DateTime.UtcNow;
                Input.CreatedDateTime = DateTime.UtcNow;

                var result = await _categoryservice.CreateCategory(Input);



                if (result != null)
                {
                    _logger.LogInformation("Category Has been Created Successfully");

                    // return RedirectToAction("CategoryList", "Home");
                    // return RedirectToPage("~/Identity/Account/Category List");
                    return RedirectToPage("CategoryList");
                }


            }


            return Page();
        }
    }

}



