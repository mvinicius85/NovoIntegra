using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class DCDOCUMENTARCHIVALMap : EntityTypeConfiguration<DCDOCUMENTARCHIVAL>
    {
        public DCDOCUMENTARCHIVALMap()
        {
            // Primary Key
            this.HasKey(t => t.CDDOCUMENT);

            // Properties
            this.Property(t => t.CDDOCUMENT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IDMEDIAPOSITION)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DCDOCUMENTARCHIVAL");
            this.Property(t => t.CDDOCUMENT).HasColumnName("CDDOCUMENT");
            this.Property(t => t.CDPHYSFILECURRENT).HasColumnName("CDPHYSFILECURRENT");
            this.Property(t => t.CDPHYSFILEINTERMED).HasColumnName("CDPHYSFILEINTERMED");
            this.Property(t => t.CDPHYSFILEFINLDEST).HasColumnName("CDPHYSFILEFINLDEST");
            this.Property(t => t.FGUSESTATUS).HasColumnName("FGUSESTATUS");
            this.Property(t => t.FGSTATUSPHYSFILE).HasColumnName("FGSTATUSPHYSFILE");
            this.Property(t => t.CDUSERARCCURRENT).HasColumnName("CDUSERARCCURRENT");
            this.Property(t => t.DTARCCURRENT).HasColumnName("DTARCCURRENT");
            this.Property(t => t.CDUSERARCINTERMED).HasColumnName("CDUSERARCINTERMED");
            this.Property(t => t.DTARCINTERMED).HasColumnName("DTARCINTERMED");
            this.Property(t => t.CDUSERARCFINLDEST).HasColumnName("CDUSERARCFINLDEST");
            this.Property(t => t.DTARCFINLDEST).HasColumnName("DTARCFINLDEST");
            this.Property(t => t.CDMEDIA).HasColumnName("CDMEDIA");
            this.Property(t => t.CDUSERREC).HasColumnName("CDUSERREC");
            this.Property(t => t.DTDEADLINECURRENT).HasColumnName("DTDEADLINECURRENT");
            this.Property(t => t.DTDEADLINEINTERMED).HasColumnName("DTDEADLINEINTERMED");
            this.Property(t => t.DTUSERREC).HasColumnName("DTUSERREC");
            this.Property(t => t.DTDEADLINEREC).HasColumnName("DTDEADLINEREC");
            this.Property(t => t.FGACTIONSTATUS).HasColumnName("FGACTIONSTATUS");
            this.Property(t => t.CDCURRENTRECEIPT).HasColumnName("CDCURRENTRECEIPT");
            this.Property(t => t.CDINTERMEDRECEIPT).HasColumnName("CDINTERMEDRECEIPT");
            this.Property(t => t.CDFINLDESTRECEIPT).HasColumnName("CDFINLDESTRECEIPT");
            this.Property(t => t.IDMEDIAPOSITION).HasColumnName("IDMEDIAPOSITION");
            this.Property(t => t.CDMEDIARECEIPT).HasColumnName("CDMEDIARECEIPT");
            this.Property(t => t.CDCOMPLIENCERET).HasColumnName("CDCOMPLIENCERET");
            this.Property(t => t.CDREVISION).HasColumnName("CDREVISION");
        }
    }
}
