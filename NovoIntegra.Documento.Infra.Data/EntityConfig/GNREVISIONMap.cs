using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class GNREVISIONMap : EntityTypeConfiguration<GNREVISION>
    {
        public GNREVISIONMap()
        {
            // Primary Key
            this.HasKey(t => t.CDREVISION);

            // Properties
            this.Property(t => t.CDREVISION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IDREVISION)
                .HasMaxLength(50);

            this.Property(t => t.NMUSERUPD)
                .HasMaxLength(255);

            this.Property(t => t.TMREVISION)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("GNREVISION");
            this.Property(t => t.CDREVISION).HasColumnName("CDREVISION");
            this.Property(t => t.IDREVISION).HasColumnName("IDREVISION");
            this.Property(t => t.DTREVISION).HasColumnName("DTREVISION");
            this.Property(t => t.FGSTATUS).HasColumnName("FGSTATUS");
            this.Property(t => t.DTREVCREATE).HasColumnName("DTREVCREATE");
            this.Property(t => t.CDREVUSERCREATE).HasColumnName("CDREVUSERCREATE");
            this.Property(t => t.DTREVRELEASE).HasColumnName("DTREVRELEASE");
            this.Property(t => t.CDREVUSERRELEASE).HasColumnName("CDREVUSERRELEASE");
            this.Property(t => t.DSJUSTIFY).HasColumnName("DSJUSTIFY");
            this.Property(t => t.FGREVCLOSEMETHOD).HasColumnName("FGREVCLOSEMETHOD");
            this.Property(t => t.DTREVPROGSTART).HasColumnName("DTREVPROGSTART");
            this.Property(t => t.DTREVPROGFINISH).HasColumnName("DTREVPROGFINISH");
            this.Property(t => t.DTREVREALSTART).HasColumnName("DTREVREALSTART");
            this.Property(t => t.DTREVREALFINISH).HasColumnName("DTREVREALFINISH");
            this.Property(t => t.DTREVRELEASEDEAD).HasColumnName("DTREVRELEASEDEAD");
            this.Property(t => t.CDREASON).HasColumnName("CDREASON");
            this.Property(t => t.CDISOSYSTEM).HasColumnName("CDISOSYSTEM");
            this.Property(t => t.DSREVISIONRELEASE).HasColumnName("DSREVISIONRELEASE");
            this.Property(t => t.DTINSERT).HasColumnName("DTINSERT");
            this.Property(t => t.DTUPDATE).HasColumnName("DTUPDATE");
            this.Property(t => t.NMUSERUPD).HasColumnName("NMUSERUPD");
            this.Property(t => t.TMREVISION).HasColumnName("TMREVISION");
            this.Property(t => t.CDREVISIONSTATUS).HasColumnName("CDREVISIONSTATUS");
            this.Property(t => t.CDREVCONFIG).HasColumnName("CDREVCONFIG");
            this.Property(t => t.CDACTIONASSOC).HasColumnName("CDACTIONASSOC");
            this.Property(t => t.DTVALIDITY).HasColumnName("DTVALIDITY");
            this.Property(t => t.FGVALIDITY).HasColumnName("FGVALIDITY");
            this.Property(t => t.QTVALIDITY).HasColumnName("QTVALIDITY");
            this.Property(t => t.CDASSOC).HasColumnName("CDASSOC");
        }
    }
}
