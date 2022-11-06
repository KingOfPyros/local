namespace WebApplication1.Models.UnitOfWorks.User
{
    public class AutWork : IDisposable
    {
        LocalHostContext productContext;
        private AutRepo autRepo;

        public AutRepo AdminRepo
        {
            get
            {
                if (autRepo == null)
                    autRepo = new AutRepo(productContext);
                return autRepo;
            }
        }

        public AutWork()
        {
            productContext = new LocalHostContext();
        }
        public void Dispose() => GC.SuppressFinalize(this);

    }
}
