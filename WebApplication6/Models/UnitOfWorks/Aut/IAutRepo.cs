namespace WebApplication1.Models.UnitOfWorks.User
{
    public interface IAutRepo<T> where T : class
    {
        T Get(int id);
        T Get(string Name,string SecondName);
        Product Get(string Name, int Password);
        IEnumerable<T> GetAllA();
    }
}
