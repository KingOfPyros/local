namespace WebApplication1.Models.UnitOfWorks.User
{
    public class RegRepo : IRegRepo<Product>
    {
        public LocalHostContext context;
        public RegRepo(LocalHostContext context)
        {
            this.context = context;
        }
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        public Product Get(int id, string Name, int Password) => context.Products.Find(id, Name, Password);

        public Product Get(string Name, string Password)
        {
            throw new NotImplementedException();
        }

#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        public IEnumerable<Product> GetAll() => context.Products;

        Product IRegRepo<Product>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Product IRegRepo<Product>.Get(string Name, int Password)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IRegRepo<Product>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
