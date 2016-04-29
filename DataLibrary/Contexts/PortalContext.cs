using System.Data.Entity;
using InternalPortal.DataLayer.BusinessObjects;

namespace InternalPortal.DataLayer.DataLibrary.Contexts
{
    public class PortalContext: DbContext
    {
        public PortalContext(): base("DbConnectionString")
        {
            Database.SetInitializer<PortalContext>(new DropCreateDatabaseIfModelChanges<PortalContext>());
        }
        public DbSet<Category> categories { get; set; }

        public DbSet<News> news { get; set; }

        public DbSet<Comment> comments { get; set; }

        

    }
}
