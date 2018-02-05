using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class GNSEQUENCEMap : EntityTypeConfiguration<GNSEQUENCE>
    {
        public GNSEQUENCEMap()
        {
            // Primary Key
            this.HasKey(t => t.NMTABLE);

            // Properties
            this.Property(t => t.NMTABLE)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("GNSEQUENCE");
            this.Property(t => t.NMTABLE).HasColumnName("NMTABLE");
            this.Property(t => t.CDLASTCODE).HasColumnName("CDLASTCODE");
        }
    }
}
