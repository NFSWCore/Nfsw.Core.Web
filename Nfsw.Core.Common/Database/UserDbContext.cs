using Microsoft.EntityFrameworkCore;
using Victory.TransferObjects.User;

namespace Nfsw.Core.Common.Database
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) :
            base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
