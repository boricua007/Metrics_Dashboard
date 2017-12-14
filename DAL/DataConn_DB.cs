using DAL.Classes;
using System.Data.Entity;
using System;

namespace DAL
{
    public class DataConn_DB : DbContext
    {
        public DbSet<Client> clients { get; set; }






        public DataConn_DB( ) : base( "Metrics_Dashboard" )
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
    }
}
