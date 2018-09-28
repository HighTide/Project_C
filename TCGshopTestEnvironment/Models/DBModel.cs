using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace TCGshopTestEnvironment.Models
{
    public class DBModel : IdentityDbContext<UserAccount>
    {
        public DBModel(DbContextOptions<DBModel> options) : base(options) { 

        }
        public DbSet<UserAccount> userAccount { get; set; }
    }
}
