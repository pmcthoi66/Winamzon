namespace Winamz.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private WinamzDbContext dbContext;

        public WinamzDbContext Init()
        {
            return dbContext ?? (dbContext = new WinamzDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}