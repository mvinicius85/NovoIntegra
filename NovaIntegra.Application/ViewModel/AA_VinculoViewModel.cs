using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaIntegra.Application.ViewModel
{
    public class AA_VinculoViewModel
    {
        public AA_VinculoViewModel()
        {

        }
        public AA_VinculoViewModel(string _idcateg, decimal _codatrib, string _nmcamp, 
            bool _indt, int _codtpcamp,
            ADATTRIBUTEViewModel _atrib, AA_TipoCampoViewModel _tpcampo )
        {
            IDCategory = _idcateg;
            CDAttribute_SE = _codatrib;
            NmCampoImagem = _nmcamp;
            Ind_Titulo = _indt;
            Cod_TipoCampo = _codtpcamp;
            ADATTRIBUTE = _atrib;
            AA_TipoCampo = _tpcampo;
        }
        public int Cod_Vinculo { get; set; }
        public string IDCategory { get; set; }
        public Nullable<decimal> CDAttribute_SE { get; set; }
        public string NmCampoImagem { get; set; }
        public bool Ind_Titulo { get; set; }
        public int Cod_TipoCampo { get; set; }
        public virtual ADATTRIBUTEViewModel ADATTRIBUTE { get; set; }
        public string nmAtributo { get { return this.ADATTRIBUTE.NMATTRIBUTE; } }
        public virtual AA_TipoCampoViewModel AA_TipoCampo { get; set; }
        public string nmTipoCampo { get { return this.AA_TipoCampo.Descricao ; } }
    }
}
