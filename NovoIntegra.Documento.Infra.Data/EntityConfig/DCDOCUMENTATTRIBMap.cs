using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class DCDOCUMENTATTRIBMap : EntityTypeConfiguration<DCDOCUMENTATTRIB>
    {
        public DCDOCUMENTATTRIBMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CDATTRIBUTE, t.CDREVISION });

            // Properties
            this.Property(t => t.CDATTRIBUTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NMVALUE)
                .HasMaxLength(255);

            this.Property(t => t.NMUSERUPD)
                .HasMaxLength(255);

            this.Property(t => t.NMREFCODE)
                .HasMaxLength(255);

            this.Property(t => t.CDREVISION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DCDOCUMENTATTRIB");
            this.Property(t => t.CDDOCUMENT).HasColumnName("CDDOCUMENT");
            this.Property(t => t.CDATTRIBUTE).HasColumnName("CDATTRIBUTE");
            this.Property(t => t.CDVALUE).HasColumnName("CDVALUE");
            this.Property(t => t.NMVALUE).HasColumnName("NMVALUE");
            this.Property(t => t.VLVALUE).HasColumnName("VLVALUE");
            this.Property(t => t.DTVALUE).HasColumnName("DTVALUE");
            this.Property(t => t.DSVALUE).HasColumnName("DSVALUE");
            this.Property(t => t.NRORDER).HasColumnName("NRORDER");
            this.Property(t => t.FGREQUIRED).HasColumnName("FGREQUIRED");
            this.Property(t => t.DTINSERT).HasColumnName("DTINSERT");
            this.Property(t => t.DTUPDATE).HasColumnName("DTUPDATE");
            this.Property(t => t.NMUSERUPD).HasColumnName("NMUSERUPD");
            this.Property(t => t.NMREFCODE).HasColumnName("NMREFCODE");
            this.Property(t => t.CDREVISION).HasColumnName("CDREVISION");
            this.Property(t => t.FGREADONLY).HasColumnName("FGREADONLY");
        }
    }
}
