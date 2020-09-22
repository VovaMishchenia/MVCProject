namespace GameStoreDAL
{
    using GameStoreDAL.Entities;
    using GameStoreDAL.Initializer;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Game> Games { get; set; }
        public ApplicationContext()
            : base("name=ApplicationContext")
        {
            Database.SetInitializer(new Gamesinitializer());
        }

    }

 
}