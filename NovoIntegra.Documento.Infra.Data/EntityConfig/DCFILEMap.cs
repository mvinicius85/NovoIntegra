using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class DCFILEMap : EntityTypeConfiguration<DCFILE>
    {
        public DCFILEMap()
        {
            // Primary Key
            this.HasKey(t => t.CDCOMPLEXFILECONT);

            // Properties
            this.Property(t => t.CDCOMPLEXFILECONT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DCFILE");
            this.Property(t => t.CDCOMPLEXFILECONT).HasColumnName("CDCOMPLEXFILECONT");
            this.Property(t => t.CDDOCUMENT).HasColumnName("CDDOCUMENT");
            this.Property(t => t.CDREVISION).HasColumnName("CDREVISION");
        }
    }
}
