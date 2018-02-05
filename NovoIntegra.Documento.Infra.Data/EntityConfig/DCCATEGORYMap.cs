using NovoIntegra.Documento.Domain.Entities.Documento;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NovoIntegra.Documento.Infra.Data.EntityConfig
{
    public class DCCATEGORYMap : EntityTypeConfiguration<DCCATEGORY>
    {
        public DCCATEGORYMap()
        {
            // Primary Key
            this.HasKey(t => t.CDCATEGORY);

            // Properties
            this.Property(t => t.CDCATEGORY)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NMCATEGORY)
                .HasMaxLength(255);

            this.Property(t => t.IDCATEGORY)
                .HasMaxLength(50);

            this.Property(t => t.NMUSERUPD)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("DCCATEGORY");
            this.Property(t => t.CDCATEGORY).HasColumnName("CDCATEGORY");
            this.Property(t => t.CDCATEGORYOWNER).HasColumnName("CDCATEGORYOWNER");
            this.Property(t => t.NMCATEGORY).HasColumnName("NMCATEGORY");
            this.Property(t => t.IDCATEGORY).HasColumnName("IDCATEGORY");
            this.Property(t => t.FGLOGO).HasColumnName("FGLOGO");
            this.Property(t => t.FGENABLEPHYSFILE).HasColumnName("FGENABLEPHYSFILE");
            this.Property(t => t.FGENABLEREVISION).HasColumnName("FGENABLEREVISION");
            this.Property(t => t.FGENABLEREVKNOW).HasColumnName("FGENABLEREVKNOW");
            this.Property(t => t.FGENABLEVALID).HasColumnName("FGENABLEVALID");
            this.Property(t => t.DSCATEGORY).HasColumnName("DSCATEGORY");
            this.Property(t => t.QTCONFDOCLOANDEAD).HasColumnName("QTCONFDOCLOANDEAD");
            this.Property(t => t.CDCOMPLIENCERET).HasColumnName("CDCOMPLIENCERET");
            this.Property(t => t.QTDOCDEVOLDEAD).HasColumnName("QTDOCDEVOLDEAD");
            this.Property(t => t.FGAUTOADDRESS).HasColumnName("FGAUTOADDRESS");
            this.Property(t => t.FGREVKNOWENABLECOM).HasColumnName("FGREVKNOWENABLECOM");
            this.Property(t => t.QTREVKNOWDUEDATE).HasColumnName("QTREVKNOWDUEDATE");
            this.Property(t => t.FGREVKNOWSENDAFTER).HasColumnName("FGREVKNOWSENDAFTER");
            this.Property(t => t.CDREVKNOWSDCOMTEAM).HasColumnName("CDREVKNOWSDCOMTEAM");
            this.Property(t => t.FGREVKNOWSENDTYPE).HasColumnName("FGREVKNOWSENDTYPE");
            this.Property(t => t.FGREVID).HasColumnName("FGREVID");
            this.Property(t => t.FGREVAPPROVALMODE).HasColumnName("FGREVAPPROVALMODE");
            this.Property(t => t.FGREVRELEASEMODE).HasColumnName("FGREVRELEASEMODE");
            this.Property(t => t.QTREVRETENTION).HasColumnName("QTREVRETENTION");
            this.Property(t => t.FGREVRETENTIONMODE).HasColumnName("FGREVRETENTIONMODE");
            this.Property(t => t.QTREVREQUESTAPPROV).HasColumnName("QTREVREQUESTAPPROV");
            this.Property(t => t.QTREVREQUESTCANCEL).HasColumnName("QTREVREQUESTCANCEL");
            this.Property(t => t.FGCATEGORYTYPE).HasColumnName("FGCATEGORYTYPE");
            this.Property(t => t.DTINSERT).HasColumnName("DTINSERT");
            this.Property(t => t.DTUPDATE).HasColumnName("DTUPDATE");
            this.Property(t => t.NMUSERUPD).HasColumnName("NMUSERUPD");
            this.Property(t => t.FGENABLEPRINTCOPY).HasColumnName("FGENABLEPRINTCOPY");
            this.Property(t => t.FGSENDCOPYAFTER).HasColumnName("FGSENDCOPYAFTER");
            this.Property(t => t.QTDAYSENDDEADLINE).HasColumnName("QTDAYSENDDEADLINE");
            this.Property(t => t.FGOBSOLCOPYSUBMODE).HasColumnName("FGOBSOLCOPYSUBMODE");
            this.Property(t => t.QTDAYCONFDEADLINE).HasColumnName("QTDAYCONFDEADLINE");
            this.Property(t => t.QTCOLLECTDEADLINE).HasColumnName("QTCOLLECTDEADLINE");
            this.Property(t => t.FGCOPYRESPID).HasColumnName("FGCOPYRESPID");
            this.Property(t => t.CDTEAMRESPCOPY).HasColumnName("CDTEAMRESPCOPY");
            this.Property(t => t.QTVALID).HasColumnName("QTVALID");
            this.Property(t => t.FGVALIDID).HasColumnName("FGVALIDID");
            this.Property(t => t.FGVALIDACTION).HasColumnName("FGVALIDACTION");
            this.Property(t => t.QTDAYVALIDDEADLINE).HasColumnName("QTDAYVALIDDEADLINE");
            this.Property(t => t.QTDAYVALNOTBEFORE).HasColumnName("QTDAYVALNOTBEFORE");
            this.Property(t => t.FGREVALIDAPPROVAL).HasColumnName("FGREVALIDAPPROVAL");
            this.Property(t => t.FGREVALIDROUTETYPE).HasColumnName("FGREVALIDROUTETYPE");
            this.Property(t => t.FGREVALUNIQUEROUTE).HasColumnName("FGREVALUNIQUEROUTE");
            this.Property(t => t.CDREVALIDROUTE).HasColumnName("CDREVALIDROUTE");
            this.Property(t => t.CDREVISIONCOMPLIEN).HasColumnName("CDREVISIONCOMPLIEN");
            this.Property(t => t.FGREVELABCLAUSE).HasColumnName("FGREVELABCLAUSE");
            this.Property(t => t.FGREVCONSCLAUSE).HasColumnName("FGREVCONSCLAUSE");
            this.Property(t => t.FGREVAPROVCLAUSE).HasColumnName("FGREVAPROVCLAUSE");
            this.Property(t => t.FGREVHOMOLOGCLAUSE).HasColumnName("FGREVHOMOLOGCLAUSE");
            this.Property(t => t.FGLOCKDELFILEREV).HasColumnName("FGLOCKDELFILEREV");
            this.Property(t => t.FGLOCKDELFILECUR).HasColumnName("FGLOCKDELFILECUR");
            this.Property(t => t.FGLOCKDELFILEOBSOL).HasColumnName("FGLOCKDELFILEOBSOL");
            this.Property(t => t.FGLOCKINSFILEREV).HasColumnName("FGLOCKINSFILEREV");
            this.Property(t => t.FGLOCKINSFILECUR).HasColumnName("FGLOCKINSFILECUR");
            this.Property(t => t.FGLOCKINSFILEOBSOL).HasColumnName("FGLOCKINSFILEOBSOL");
            this.Property(t => t.FGLOCKREGRELEASED).HasColumnName("FGLOCKREGRELEASED");
            this.Property(t => t.FGREVROUTETYPE).HasColumnName("FGREVROUTETYPE");
            this.Property(t => t.FGENABLEDTRAINING).HasColumnName("FGENABLEDTRAINING");
            this.Property(t => t.FGRECTRAINAFTER).HasColumnName("FGRECTRAINAFTER");
            this.Property(t => t.FGTRAINCONFRESP).HasColumnName("FGTRAINCONFRESP");
            this.Property(t => t.FGTRAINREQUIRED).HasColumnName("FGTRAINREQUIRED");
            this.Property(t => t.QTTRAINDEADLINE).HasColumnName("QTTRAINDEADLINE");
            this.Property(t => t.QTRECTRAINDEADLINE).HasColumnName("QTRECTRAINDEADLINE");
            this.Property(t => t.QTCONTRAINDEADLINE).HasColumnName("QTCONTRAINDEADLINE");
            this.Property(t => t.QTEFFECTDEADLINE).HasColumnName("QTEFFECTDEADLINE");
            this.Property(t => t.FGALLOWREVIDCHANGE).HasColumnName("FGALLOWREVIDCHANGE");
            this.Property(t => t.CDMASK).HasColumnName("CDMASK");
            this.Property(t => t.FGALLOWCHANGEID).HasColumnName("FGALLOWCHANGEID");
            this.Property(t => t.FGALLOWFINISHREV).HasColumnName("FGALLOWFINISHREV");
            this.Property(t => t.FGDENYCHANGEVALID).HasColumnName("FGDENYCHANGEVALID");
            this.Property(t => t.FGDENYTYPEAUTHOR).HasColumnName("FGDENYTYPEAUTHOR");
            this.Property(t => t.FGDENYCHANGEACCESS).HasColumnName("FGDENYCHANGEACCESS");
            this.Property(t => t.FGDENYCREATEDBY).HasColumnName("FGDENYCREATEDBY");
            this.Property(t => t.FGCATACCESSDEFAULT).HasColumnName("FGCATACCESSDEFAULT");
            this.Property(t => t.CDELETRONICFILECFG).HasColumnName("CDELETRONICFILECFG");
            this.Property(t => t.CDREVCONFIG).HasColumnName("CDREVCONFIG");
            this.Property(t => t.FGENABLED).HasColumnName("FGENABLED");
            this.Property(t => t.CDTYPEROLE).HasColumnName("CDTYPEROLE");
            this.Property(t => t.CDMAILTASKRELVAL).HasColumnName("CDMAILTASKRELVAL");
            this.Property(t => t.QTRECCRITDEADLINE).HasColumnName("QTRECCRITDEADLINE");
            this.Property(t => t.CDTEMPORALITY).HasColumnName("CDTEMPORALITY");
            this.Property(t => t.FGTRAINCRITICDEF).HasColumnName("FGTRAINCRITICDEF");
            this.Property(t => t.FGREQAPPROVINDEX).HasColumnName("FGREQAPPROVINDEX");
            this.Property(t => t.FGAPPROVINDEXTYPE).HasColumnName("FGAPPROVINDEXTYPE");
            this.Property(t => t.CDROUTEAPPROVINDEX).HasColumnName("CDROUTEAPPROVINDEX");
            this.Property(t => t.FGEDITATAPPROVAL).HasColumnName("FGEDITATAPPROVAL");
            this.Property(t => t.FGENABLEINDEXING).HasColumnName("FGENABLEINDEXING");
            this.Property(t => t.FGREQELABINDEX).HasColumnName("FGREQELABINDEX");
            this.Property(t => t.CDROUTEELABINDEX).HasColumnName("CDROUTEELABINDEX");
            this.Property(t => t.FGELABINDEXTYPE).HasColumnName("FGELABINDEXTYPE");
            this.Property(t => t.FGEXECAPPLIC).HasColumnName("FGEXECAPPLIC");
            this.Property(t => t.QTAPPLICDEADLINE).HasColumnName("QTAPPLICDEADLINE");
        }
    }
}
