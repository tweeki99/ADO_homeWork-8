namespace SecurityApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class VisitorContext : DbContext
    {
        public VisitorContext()
            : base("name=VisitorContext")
        {
        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}