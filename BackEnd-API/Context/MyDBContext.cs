using BackEnd_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_API.Context
{
    public class MyDBContext: DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        public DbSet<User> User { get; set; }

    }
}
