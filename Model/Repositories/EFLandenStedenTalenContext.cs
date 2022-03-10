using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Model.Repositories.Configuration;
using Model.Repositories.Seeding;
using Model.Entities;

namespace Model.Repositories
{
    public class EFLandenStedenTalenContext : DbContext
    {
        public static IConfigurationRoot configuration;
        bool testMode = false;

        //Associaties
        public DbSet<Land> Landen { get; set; }
        public DbSet<Stad> Steden { get; set; }
        public DbSet<Taal> Talen { get; set; }

        //Constructors
        public EFLandenStedenTalenContext() { }
        public EFLandenStedenTalenContext(DbContextOptions<EFLandenStedenTalenContext> options) : base(options) { }
        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging
                (
                    builder => builder.AddConsole().AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Information)
                );
            return serviceCollection.BuildServiceProvider().GetService<ILoggerFactory>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                configuration = new ConfigurationBuilder().SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName).AddJsonFile("appsettings.json", false).Build();
                var connectionString = configuration.GetConnectionString("eflandenstedentalen");
                if(connectionString != null)
                {
                    optionsBuilder.UseSqlServer(connectionString, options => options.MaxBatchSize(150)).UseLoggerFactory(GetLoggerFactory()).EnableSensitiveDataLogging(true).UseLazyLoadingProxies();
                }
            }
            else
            {
                testMode = true;
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration

            // Associaties
            modelBuilder.ApplyConfiguration(new LandConfiguration());
            modelBuilder.ApplyConfiguration(new StadConfiguration());
            modelBuilder.ApplyConfiguration(new TaalConfiguration());

            if (!testMode)
            {
                // Seeding
                modelBuilder.ApplyConfiguration(new LandSeeding());
                modelBuilder.ApplyConfiguration(new StadSeeding());
                modelBuilder.ApplyConfiguration(new TaalSeeding());
            }
        }
    }
}
