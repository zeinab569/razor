using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly IEntity<Student> db;

        public DetailsModel(IEntity<Student> _db) 
        {
            db = _db;
        }
        
        public Student student { get; set; }

        public IActionResult OnGet(int? id)
        {
            if(id is null)
                return BadRequest();
            Student s= db.GetByID(id.Value);
            student = s;
            if (s == null) return NotFound();
            return Page();
        }
    }
}
