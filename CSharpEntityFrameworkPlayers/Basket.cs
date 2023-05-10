using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityFrameworkPlayers
{
    public class Basket : DbContext
    {
        public DbSet<PlayerErro> Players { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=FrameworkBasketPlayers;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
