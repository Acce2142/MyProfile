using System.Data.Entity;

namespace ProjectA.Db
{
    public class DataContext : DbContext
    {
       public DataContext() : base("DefaultConnection")
        {
             
        }
    }
}
