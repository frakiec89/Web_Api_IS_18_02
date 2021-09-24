using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api_IS_18_02.DB.Model;

namespace Web_Api_IS_18_02.DB
{
    public class EfDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder )
        {
            builder.UseSqlServer("Server=192.168.10.134;database= MyTestApi; User Id=stud;Password=stud;");
        }

    }
}
