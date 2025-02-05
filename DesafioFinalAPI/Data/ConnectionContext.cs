using DesafioFinalAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace DesafioFinalAPI.Data
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql(
        "server=localhost;initial catalog=CRUD_MVC_PRODUTO;uid=root;pwd=Mysql@2025",
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.41-mysql"));
    }
}
