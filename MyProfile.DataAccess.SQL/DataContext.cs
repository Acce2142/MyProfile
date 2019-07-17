using MyProfile.Core.Models;
using System.Data.Entity;

namespace MyShop.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext ()
            : base("DefaultConnection")
        {

        }

        public DbSet<Profile> Products { get; set; }
    }
}
