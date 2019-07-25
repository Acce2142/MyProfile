using MyProfile.Core.Models;
using System.Data.Entity;

namespace MyShop.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext ()
            : base("TrueConnection")
        {

        }

        public DbSet<Profile> Products { get; set; }
    }
}
