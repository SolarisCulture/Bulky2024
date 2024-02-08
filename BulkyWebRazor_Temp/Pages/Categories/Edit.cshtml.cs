using BulkyWebRazor_Temp.Data;
using BylkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly AppDbContext _db;
        public Category? Category { get; set; }
        public EditModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if(id!= null && id != 0)
            {
                Category = _db.Categories.FirstOrDefault(u => u.CategoryId == id)!;
            }
        }

        public IActionResult OnPost()
        {
			_db.Categories.Update(Category);
			_db.SaveChanges();
            TempData["success"] = "Category Updated Successfully!";
            return RedirectToPage("Index");
        }
    }
}
