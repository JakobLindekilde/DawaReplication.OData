using JOInformatik.DawaReplication.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace DawaReplication.OData
{
    public partial class ODataDBContext : DawaReplicationDBContext
    {
        public ODataDBContext()
            : base()
        {
        }

        public ODataDBContext(DbContextOptions<DawaReplicationDBContextBase> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                        .AddJsonFile("appsettings.json")
                        .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DawaDatabase"));
        }
    }
}
