using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class DCDOCREVISIONMap : EntityTypeConfiguration<DCDOCREVISION>
    {
        public DCDOCREVISIONMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CDDOCUMENT, t.CDREVISION });

            // Properties
            this.Property(t => t.CDDOCUMENT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CDREVISION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NMTITLE)
                .HasMaxLength(255);

            this.Property(t => t.NMAUTHOR)
                .HasMaxLength(255);

            this.Property(t => t.IDDOCUMENT)
                .HasMaxLength(50);

            this.Property(t => t.NMUSERUPD)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("DCDOCREVISION");
            this.Property(t => t.CDDOCUMENT).HasColumnName("CDDOCUMENT");
            this.Property(t => t.CDREVISION).HasColumnName("CDREVISION");
            this.Property(t => t.FGCURRENT).HasColumnName("FGCURRENT");
            this.Property(t => t.FGTRAINREQUIRED).HasColumnName("FGTRAINREQUIRED");
            this.Property(t => t.DSSUMMARY).HasColumnName("DSSUMMARY");
            this.Property(t => t.NMTITLE).HasColumnName("NMTITLE");
            this.Property(t => t.NMAUTHOR).HasColumnName("NMAUTHOR");
            this.Property(t => t.IDDOCUMENT).HasColumnName("IDDOCUMENT");
            this.Property(t => t.CDCATEGORY).HasColumnName("CDCATEGORY");
            this.Property(t => t.NRHITS).HasColumnName("NRHITS");
            this.Property(t => t.DTVALIDITY).HasColumnName("DTVALIDITY");
            this.Property(t => t.QTVALIDITY).HasColumnName("QTVALIDITY");
            this.Property(t => t.FGTYPEVALID).HasColumnName("FGTYPEVALID");
            this.Property(t => t.DTINSERT).HasColumnName("DTINSERT");
            this.Property(t => t.DTUPDATE).HasColumnName("DTUPDATE");
            this.Property(t => t.NMUSERUPD).HasColumnName("NMUSERUPD");
        }
    }
}
