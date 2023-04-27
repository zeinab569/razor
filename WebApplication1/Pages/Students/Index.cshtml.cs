using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages.Students
{
    public class IndexModel : PageModel
    {
        IEntity<Student> db;

        public IndexModel(IEntity<Student> _db)
        {
            db= _db;
        }
        public List<Student> students { get; set; }
        public void OnGet()
        {
            students = db.GetAll();
        }
    }
}
