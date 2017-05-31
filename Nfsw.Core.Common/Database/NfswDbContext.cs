using Microsoft.EntityFrameworkCore;
using Nfsw.Core.Common.Structures;

namespace Nfsw.Core.Common.Database
{
    public class NfswDbContext : DbContext
    {
        public NfswDbContext(DbContextOptions<NfswDbContext> options) :
            base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}
