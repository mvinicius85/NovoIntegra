using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaIntegra.Application.ViewModel
{
    public class AA_TipoCampoViewModel
    {
        public AA_TipoCampoViewModel()
        {

        }
        public AA_TipoCampoViewModel(int _cod, string _desc)
        {
            Cod_TipoCampo = _cod;
            Descricao = _desc;
        }
        public int Cod_TipoCampo { get; set; }
        public string Descricao { get; set; }
    }
}
