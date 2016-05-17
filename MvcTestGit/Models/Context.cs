using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcTestGit.Models
{
    public class Context : DbContext 

    {
        public DbSet<Product> Produtos { get; set; }
    }
}