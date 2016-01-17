using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFTimestampAttribute
{
    public class EFContext : DbContext
    {
        public EFContext()
            : base("EFDatabase")
        {
            Database.SetInitializer<EFContext>(new DropCreateDatabaseAlways<EFContext>());
        }

        public DbSet<Employee> Employees { get; set; }
    }


}
