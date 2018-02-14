using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaIntegra.Application.ViewModel
{
    public class AA_ParametrosViewModel
    {
        public AA_ParametrosViewModel()
        {

        }

        public AA_ParametrosViewModel(string _nome, string  _desc)
        {
            NomeParametro = _nome;
            Descricao = _desc;
        }
        public AA_ParametrosViewModel(int _codparam, string _nmparam, string _desc, string _valor)
        {
            Cod_Parametro = _codparam;
            NomeParametro = _nmparam;
            Descricao = _desc;
            Valor = _valor;
        }

        public int Cod_Parametro { get; set; }
        public string NomeParametro { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }
    }
}
