using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages.Students
{
    public class CreateModel : PageModel
    {
        IEntity<Student> db;

        public CreateModel(IEntity<Student> _db) 
        {
            db= _db;
        }
        [BindProperty]
        public Student student { get; set; }

        public void OnGet()
        {

        }
        public IActionResult OnPost(Student student)
        {
            if (ModelState.IsValid)
            {
                Student s = db.GetByID(student.Id);
                if(s == null)
                {
                    db.Add(student);
                    return RedirectToPage("Index");
                    //nameof(Students)
                }
                else
                {
                    Console.WriteLine("this student exist");
                }
            }
            else
            {
                return Page();
            }
            return Page();
        }
    }
}
