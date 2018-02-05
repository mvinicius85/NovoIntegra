using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class GNASSOCMap : EntityTypeConfiguration<GNASSOC>
    {
        public GNASSOCMap()
        {
            // Primary Key
            this.HasKey(t => t.CDASSOC);

            // Properties
            this.Property(t => t.CDASSOC)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("GNASSOC");
            this.Property(t => t.CDASSOC).HasColumnName("CDASSOC");
            this.Property(t => t.NROBJECTPARENT).HasColumnName("NROBJECTPARENT");
        }
    }
}
