using Microsoft.EntityFrameworkCore;
using ServerManagement.Models;

namespace ServerManagement.Data
{
    //In memory representation of  the database
    public class ServerManagerContext : DbContext
    {
        //Inform the ServerManagerContext to use the defined connection string:
        public ServerManagerContext(DbContextOptions<ServerManagerContext> options) : base(options) { }

        public DbSet<Server> ServersManagement { get; set; }

        //Seed some data 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Model builder allows us to build any relationships, PK, constraints, etc.
            // Explicitly set IsOnline (or any other dynamic property) so the model is deterministic
            modelBuilder.Entity<Server>().HasData(
                new Server { Id = 1, Name = "Server1", City = "Toronto", IsOnline = false },
                new Server { Id = 2, Name = "Server2", City = "Toronto", IsOnline = true },
                new Server { Id = 3, Name = "Server3", City = "Toronto", IsOnline = false },
                new Server { Id = 4, Name = "Server4", City = "Toronto", IsOnline = false },
                new Server { Id = 5, Name = "Server5", City = "Montreal", IsOnline = false },
                new Server { Id = 6, Name = "Server6", City = "Montreal", IsOnline = true },
                new Server { Id = 7, Name = "Server7", City = "Montreal", IsOnline = true },
                new Server { Id = 8, Name = "Server8", City = "Ottawa", IsOnline = true },
                new Server { Id = 9, Name = "Server9", City = "Ottawa", IsOnline = true },
                new Server { Id = 10, Name = "Server10", City = "Calgary", IsOnline = false },
                new Server { Id = 11, Name = "Server11", City = "Calgary", IsOnline = false },
                new Server { Id = 12, Name = "Server12", City = "Halifax", IsOnline = true },
                new Server { Id = 13, Name = "Server13", City = "Halifax", IsOnline = false }
            );
        }
    }
}
