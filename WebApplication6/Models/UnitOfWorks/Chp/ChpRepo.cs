namespace WebApplication1.Models.UnitOfWorks.User
{
    public class ChpRepo : IChpRepo<Product>
    {
        public LocalHostContext context;
        public ChpRepo(LocalHostContext context)
        {
            this.context = context;
        }
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        public Product Get(int id, int Password1, int Password2) => context.Products.Find(id, Password1, Password2);

        public Product Get(string Name, string Password)
        {
            throw new NotImplementedException();
        }

        public Product Get(string Name, int Password)
        {
            throw new NotImplementedException();
        }

#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        public IEnumerable<Product> GetAllC() => context.Products;

        public Product GetAllC(int id)
        {
            throw new NotImplementedException();
        }

        Product IChpRepo<Product>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Product IChpRepo<Product>.Get(int Password1, int Password2)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IChpRepo<Product>.GetAllC()
        {
            throw new NotImplementedException();
        }
    }
}
