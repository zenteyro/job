using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfService
{
    public class ClientSessionContext : DbContext
    {
        public ClientSessionContext() : base("ClientSessionContext")
        { }

        public DbSet<Session> Sessions { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}