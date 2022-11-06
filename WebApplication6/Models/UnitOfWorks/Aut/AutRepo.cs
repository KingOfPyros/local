namespace WebApplication1.Models.UnitOfWorks.User
{
    public class AutRepo : IAutRepo<Product>
    {
        public LocalHostContext context;
        public AutRepo(LocalHostContext context)
        {
            this.context = context;
        }
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        public Product Get(int id, string Name, int Password) => context.Products.Find(id, Name, Password);

        public Product Get(string Name, string SecondName)
        {
            throw new NotImplementedException();
        }

#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        public IEnumerable<Product> GetAllA() => context.Products;

        Product IAutRepo<Product>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Product IAutRepo<Product>.Get(string Name, int Password)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IAutRepo<Product>.GetAllA()
        {
            throw new NotImplementedException();
        }
    }
}
