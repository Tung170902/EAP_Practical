using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAP_Practical.Model
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }

    }
}
