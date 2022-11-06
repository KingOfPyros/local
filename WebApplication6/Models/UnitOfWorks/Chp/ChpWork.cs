namespace WebApplication1.Models.UnitOfWorks.User
{
    public class ChpWork : IDisposable
    {
        LocalHostContext productContext;
        private ChpRepo chpRepo;

        public ChpRepo ChpRepo
        {
            get
            {
                if (chpRepo == null)
                    chpRepo = new ChpRepo(productContext);
                return chpRepo;
            }
        }

        public ChpWork()
        {
            productContext = new LocalHostContext();
        }
        public void Dispose() => GC.SuppressFinalize(this);

    }
}
