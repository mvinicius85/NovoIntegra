using NovoIntegra.Documento.Domain.Entities.Documento;
using NovoIntegra.Documento.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Infra.Data.Contexto
{
    public partial class SeSuiteContext : DbContext
    {
        static SeSuiteContext()
        {
            Database.SetInitializer<SeSuiteContext>(null);
        }

        public SeSuiteContext()
           : base("Data Source=192.168.1.32\\sqlexpress;Initial Catalog=SESUITE_COTIA;Persist Security Info=True;User ID=sa; Password=P@ssw0rd;MultipleActiveResultSets=True;App=NovoIntegra")
        {
        }

        public DbSet<AA_Log> AA_Log { get; set; }
        public DbSet<AA_Parametros> AA_Parametros { get; set; }
        public DbSet<AA_TipoCampo> AA_TipoCampo { get; set; }
        public DbSet<AA_Vinculo> AA_Vinculo { get; set; }
        public DbSet<ADINTERFACE> ADINTERFACEs { get; set; }
        public DbSet<ADATTRIBUTE> ADATTRIBUTEs { get; set; }
        public DbSet<DCCATEGORY> DCCATEGORies { get; set; }
        public DbSet<DCDOCREVISION> DCDOCREVISIONs { get; set; }
        public DbSet<DCDOCUMENT> DCDOCUMENTs { get; set; }
        public DbSet<DCDOCUMENTARCHIVAL> DCDOCUMENTARCHIVALs { get; set; }
        public DbSet<DCDOCUMENTATTRIB> DCDOCUMENTATTRIBs { get; set; }
        public DbSet<DCFILE> DCFILEs { get; set; }
        public DbSet<GNASSOC> GNASSOCs { get; set; }
        public DbSet<GNCOMPFILECONTCOPY> GNCOMPFILECONTCOPies { get; set; }
        public DbSet<GNREVISION> GNREVISIONs { get; set; }
        public DbSet<GNSEQUENCE> GNSEQUENCEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AA_LogMap());
            modelBuilder.Configurations.Add(new AA_ParametrosMap());
            modelBuilder.Configurations.Add(new AA_TipoCampoMap());
            modelBuilder.Configurations.Add(new AA_VinculoMap());
            modelBuilder.Configurations.Add(new ADATTRIBUTEMap());
            modelBuilder.Configurations.Add(new ADINTERFACEMap());
            modelBuilder.Configurations.Add(new DCCATEGORYMap());
            modelBuilder.Configurations.Add(new DCDOCREVISIONMap());
            modelBuilder.Configurations.Add(new DCDOCUMENTMap());
            modelBuilder.Configurations.Add(new DCDOCUMENTARCHIVALMap());
            modelBuilder.Configurations.Add(new DCDOCUMENTATTRIBMap());
            modelBuilder.Configurations.Add(new DCFILEMap());
            modelBuilder.Configurations.Add(new GNASSOCMap());
            modelBuilder.Configurations.Add(new GNCOMPFILECONTCOPYMap());
            modelBuilder.Configurations.Add(new GNREVISIONMap());
            modelBuilder.Configurations.Add(new GNSEQUENCEMap());
        }

        public override int SaveChanges()
        {



            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("dat_inc") != null))
            {


                if (entry.State == EntityState.Added)
                {
                    entry.Property("dat_inc").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("dat_inc").IsModified = false;
                }
            }

            var rowsaffected = base.SaveChanges();

            return rowsaffected;
        }


    }



    public static class ChangeDb
    {
        public static void ChangeConnection(this SeSuiteContext context, string cn)
        {
            context.Database.Connection.ConnectionString = cn;
        }
    }
}
