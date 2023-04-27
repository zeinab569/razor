using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages.Students
{
    public class EditModel : PageModel
    {
        private readonly IEntity<Student> db;

        public EditModel(IEntity<Student> _db) 
        {
            db = _db;
        }
        [BindProperty]
        public Student student { get; set; }

        public IActionResult OnGet(int? id)
        {
            
            if (id is null)
                return BadRequest();
            student = db.GetByID(id.Value);
            return Page();

        }
        public IActionResult OnPost()
        {
            if (student != null)
            {
                if (ModelState.IsValid)
                {
                    db.Update(student);
                    return RedirectToPage("index");
                }
                else { return Page(); } 
            }
            else
            {
                return NotFound();
            }
        }
    }
}
