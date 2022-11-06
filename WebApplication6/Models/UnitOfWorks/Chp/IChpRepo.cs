namespace WebApplication1.Models.UnitOfWorks.User
{
    public interface IChpRepo<T> where T : class
    {
        T Get(int id);
        T Get(string Name,string Password);
        Product Get(string Name, int Password);
        Product Get(int Password1, int Password2);
        IEnumerable<T> GetAllC();
        Product GetAllC(int id);
    }
}
