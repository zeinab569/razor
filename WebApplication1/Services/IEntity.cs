namespace WebApplication1.Services
{
    public interface IEntity<T>
    {
        public List<T> GetAll();
        public T GetByID(int id);
        public T Add(T t);
        public T Update(T t);
        public void Delete(int id);
    }
}
