using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web;
using DAL.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL.ContextDB
{
    public class ContextDb : DbContext
    {
        public ContextDb() : base("Cadastro")
        {

        }

        // Remove a pluralização da tabelas
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ConsoleBrowser> ConsoleBrowser { get; set; }
    }

   
}


