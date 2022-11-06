namespace WebApplication1.Models.UnitOfWorks.User
{
    public class RegWork : IDisposable
    {
        LocalHostContext productContext;
        private RegRepo regRepo;

        public RegRepo RegRepo
        {
            get
            {
                if (regRepo == null)
                    regRepo = new RegRepo(productContext);
                return regRepo;
            }
        }

        public RegWork()
        {
            productContext = new LocalHostContext();
        }
        public void Dispose() => GC.SuppressFinalize(this);

    }
}
