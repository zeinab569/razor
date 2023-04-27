using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class StudentMoc : IEntity<Student>
    {
        static List<Student> students = new List<Student>()
        {
           new Student{Id=1,Name="zeinab",Age=22},
           new Student{Id=2,Name="Aza",Age=24},
           new Student{Id=3,Name="amal",Age=30},

       };
        public Student Add(Student t)
        {
            students.Add(t);
            return t;
        }

        public void Delete(int id)
        {
            Student s = students.FirstOrDefault(a => a.Id == id);
            students.Remove(s);
        }

        public List<Student> GetAll()
        {
            return students.ToList();
        }

        public Student GetByID(int id)
        {
             return students.FirstOrDefault(a => a.Id == id);
        }

        public Student Update(Student t)
        {
            Student oldone = students.FirstOrDefault(a => a.Id == t.Id);
            oldone.Name = t.Name;
            oldone.Age=t.Age;
            return oldone;
        }
    }
}
