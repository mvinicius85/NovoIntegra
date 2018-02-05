using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class DCDOCUMENTMap : EntityTypeConfiguration<DCDOCUMENT>
    {
        public DCDOCUMENTMap()
        {
            // Primary Key
            this.HasKey(t => t.CDDOCUMENT);

            // Properties
            this.Property(t => t.CDDOCUMENT)
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
            this.ToTable("DCDOCUMENT");
            this.Property(t => t.CDDOCUMENT).HasColumnName("CDDOCUMENT");
            this.Property(t => t.CDCATEGORY).HasColumnName("CDCATEGORY");
            this.Property(t => t.DTDOCUMENT).HasColumnName("DTDOCUMENT");
            this.Property(t => t.FGSTATUS).HasColumnName("FGSTATUS");
            this.Property(t => t.DSSUMMARY).HasColumnName("DSSUMMARY");
            this.Property(t => t.NMTITLE).HasColumnName("NMTITLE");
            this.Property(t => t.NMAUTHOR).HasColumnName("NMAUTHOR");
            this.Property(t => t.IDDOCUMENT).HasColumnName("IDDOCUMENT");
            this.Property(t => t.DSDOCCANCEL).HasColumnName("DSDOCCANCEL");
            this.Property(t => t.FGUSECATACCESSROLE).HasColumnName("FGUSECATACCESSROLE");
            this.Property(t => t.CDCREATEDBY).HasColumnName("CDCREATEDBY");
            this.Property(t => t.NRHITS).HasColumnName("NRHITS");
            this.Property(t => t.DTINSERT).HasColumnName("DTINSERT");
            this.Property(t => t.DTUPDATE).HasColumnName("DTUPDATE");
            this.Property(t => t.NMUSERUPD).HasColumnName("NMUSERUPD");
            this.Property(t => t.DTVALIDITY).HasColumnName("DTVALIDITY");
            this.Property(t => t.QTVALIDITY).HasColumnName("QTVALIDITY");
            this.Property(t => t.FGTYPEVALID).HasColumnName("FGTYPEVALID");
            this.Property(t => t.CDPROD).HasColumnName("CDPROD");
            this.Property(t => t.CDAPPROV).HasColumnName("CDAPPROV");
            this.Property(t => t.CDTEMPARCHIVAL).HasColumnName("CDTEMPARCHIVAL");
            this.Property(t => t.CDFAVORITE).HasColumnName("CDFAVORITE");
        }
    }
}
