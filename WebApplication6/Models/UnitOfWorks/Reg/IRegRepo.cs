namespace WebApplication1.Models.UnitOfWorks.User
{
    public interface IRegRepo<T> where T : class
    {
        T Get(int id);
        T Get(string Name,string Password);
        Product Get(string Name, int Password);
        IEnumerable<T> GetAll();
    }
}
