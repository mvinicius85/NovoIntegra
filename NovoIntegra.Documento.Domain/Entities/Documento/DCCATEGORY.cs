using System;
using System.Collections.Generic;
using System.Text;

namespace NovoIntegra.Documento.Domain.Entities.Documento
{
    public partial class DCCATEGORY
    {
        public decimal CDCATEGORY { get; set; }
        public Nullable<decimal> CDCATEGORYOWNER { get; set; }
        public string NMCATEGORY { get; set; }
        public string IDCATEGORY { get; set; }
        public Nullable<decimal> FGLOGO { get; set; }
        public Nullable<decimal> FGENABLEPHYSFILE { get; set; }
        public Nullable<decimal> FGENABLEREVISION { get; set; }
        public Nullable<decimal> FGENABLEREVKNOW { get; set; }
        public Nullable<decimal> FGENABLEVALID { get; set; }
        public string DSCATEGORY { get; set; }
        public Nullable<decimal> QTCONFDOCLOANDEAD { get; set; }

        public Nullable<decimal> CDCOMPLIENCERET { get; set; }
        public Nullable<decimal> QTDOCDEVOLDEAD { get; set; }
        public Nullable<decimal> FGAUTOADDRESS { get; set; }
        public Nullable<decimal> FGREVKNOWENABLECOM { get; set; }
        public Nullable<decimal> QTREVKNOWDUEDATE { get; set; }
        public Nullable<decimal> FGREVKNOWSENDAFTER { get; set; }
        public Nullable<decimal> CDREVKNOWSDCOMTEAM { get; set; }
        public Nullable<decimal> FGREVKNOWSENDTYPE { get; set; }
        public Nullable<decimal> FGREVID { get; set; }
        public Nullable<decimal> FGREVAPPROVALMODE { get; set; }
        public Nullable<decimal> FGREVRELEASEMODE { get; set; }
        public Nullable<decimal> QTREVRETENTION { get; set; }
        public Nullable<decimal> FGREVRETENTIONMODE { get; set; }
        public Nullable<decimal> QTREVREQUESTAPPROV { get; set; }
        public Nullable<decimal> QTREVREQUESTCANCEL { get; set; }
        public Nullable<decimal> FGCATEGORYTYPE { get; set; }
        public Nullable<System.DateTime> DTINSERT { get; set; }
        public Nullable<System.DateTime> DTUPDATE { get; set; }
        public string NMUSERUPD { get; set; }
        public Nullable<decimal> FGENABLEPRINTCOPY { get; set; }
        public Nullable<decimal> FGSENDCOPYAFTER { get; set; }
        public Nullable<decimal> QTDAYSENDDEADLINE { get; set; }
        public Nullable<decimal> FGOBSOLCOPYSUBMODE { get; set; }
        public Nullable<decimal> QTDAYCONFDEADLINE { get; set; }
        public Nullable<decimal> QTCOLLECTDEADLINE { get; set; }
        public Nullable<decimal> FGCOPYRESPID { get; set; }
        public Nullable<decimal> CDTEAMRESPCOPY { get; set; }
        public Nullable<decimal> QTVALID { get; set; }
        public Nullable<decimal> FGVALIDID { get; set; }
        public Nullable<decimal> FGVALIDACTION { get; set; }
        public Nullable<decimal> QTDAYVALIDDEADLINE { get; set; }
        public Nullable<decimal> QTDAYVALNOTBEFORE { get; set; }
        public Nullable<decimal> FGREVALIDAPPROVAL { get; set; }
        public Nullable<decimal> FGREVALIDROUTETYPE { get; set; }
        public Nullable<decimal> FGREVALUNIQUEROUTE { get; set; }
        public Nullable<decimal> CDREVALIDROUTE { get; set; }
        public Nullable<decimal> CDREVISIONCOMPLIEN { get; set; }
        public Nullable<decimal> FGREVELABCLAUSE { get; set; }
        public Nullable<decimal> FGREVCONSCLAUSE { get; set; }
        public Nullable<decimal> FGREVAPROVCLAUSE { get; set; }
        public Nullable<decimal> FGREVHOMOLOGCLAUSE { get; set; }
        public Nullable<decimal> FGLOCKDELFILEREV { get; set; }
        public Nullable<decimal> FGLOCKDELFILECUR { get; set; }
        public Nullable<decimal> FGLOCKDELFILEOBSOL { get; set; }
        public Nullable<decimal> FGLOCKINSFILEREV { get; set; }
        public Nullable<decimal> FGLOCKINSFILECUR { get; set; }
        public Nullable<decimal> FGLOCKINSFILEOBSOL { get; set; }
        public Nullable<decimal> FGLOCKREGRELEASED { get; set; }
        public Nullable<decimal> FGREVROUTETYPE { get; set; }
        public Nullable<decimal> FGENABLEDTRAINING { get; set; }
        public Nullable<decimal> FGRECTRAINAFTER { get; set; }
        public Nullable<decimal> FGTRAINCONFRESP { get; set; }
        public Nullable<decimal> FGTRAINREQUIRED { get; set; }
        public Nullable<decimal> QTTRAINDEADLINE { get; set; }
        public Nullable<decimal> QTRECTRAINDEADLINE { get; set; }
        public Nullable<decimal> QTCONTRAINDEADLINE { get; set; }
        public Nullable<decimal> QTEFFECTDEADLINE { get; set; }
        public Nullable<decimal> FGALLOWREVIDCHANGE { get; set; }
        public Nullable<decimal> CDMASK { get; set; }
        public Nullable<decimal> FGALLOWCHANGEID { get; set; }
        public Nullable<decimal> FGALLOWFINISHREV { get; set; }
        public Nullable<decimal> FGDENYCHANGEVALID { get; set; }
        public Nullable<decimal> FGDENYTYPEAUTHOR { get; set; }
        public Nullable<decimal> FGDENYCHANGEACCESS { get; set; }
        public Nullable<decimal> FGDENYCREATEDBY { get; set; }
        public Nullable<decimal> FGCATACCESSDEFAULT { get; set; }
        public Nullable<decimal> CDELETRONICFILECFG { get; set; }
        public Nullable<decimal> CDREVCONFIG { get; set; }
        public Nullable<decimal> FGENABLED { get; set; }
        public Nullable<decimal> CDTYPEROLE { get; set; }
        public Nullable<decimal> CDMAILTASKRELVAL { get; set; }
        public Nullable<decimal> QTRECCRITDEADLINE { get; set; }
        public Nullable<decimal> CDTEMPORALITY { get; set; }
        public Nullable<decimal> FGTRAINCRITICDEF { get; set; }
        public Nullable<decimal> FGREQAPPROVINDEX { get; set; }
        public Nullable<decimal> FGAPPROVINDEXTYPE { get; set; }
        public Nullable<decimal> CDROUTEAPPROVINDEX { get; set; }
        public Nullable<decimal> FGEDITATAPPROVAL { get; set; }
        public Nullable<decimal> FGENABLEINDEXING { get; set; }
        public Nullable<decimal> FGREQELABINDEX { get; set; }
        public Nullable<decimal> CDROUTEELABINDEX { get; set; }
        public Nullable<decimal> FGELABINDEXTYPE { get; set; }
        public Nullable<decimal> FGEXECAPPLIC { get; set; }
        public Nullable<decimal> QTAPPLICDEADLINE { get; set; }


        public string MontaSWhere()
        {
            StringBuilder swhere = new StringBuilder();
            if (!String.IsNullOrEmpty(IDCATEGORY))
            {
                IDCATEGORY = "%" + IDCATEGORY + "%";
                if (swhere.Length > 0)
                {
                    swhere.Append(" and ");
                }
                swhere.Append(" cat.IDCATEGORY like @IDCATEGORY ");
            }
            if (!String.IsNullOrEmpty(NMCATEGORY))
            {
                if (swhere.Length > 0)
                {
                    swhere.Append(" and ");
                }
                swhere.Append(" cat.NMCATEGORY like @NMCATEGORY ");
            }
            if (swhere.Length > 0)
            {
                return "where " + swhere.ToString();
            }
            return swhere.ToString();
        }
    }
}
