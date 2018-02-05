using NovoIntegra.Documento.Domain.Entities.Documento;
using NovoIntegra.Documento.Domain.Interfaces.Repository;
using NovoIntegra.Documento.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Documento.Domain.Services
{
    public class GNAssocService : IGNAssocService
    {
        private readonly IGNAssocRepository _gnassocrepositoy;

        public GNAssocService(IGNAssocRepository gnassocrepositoy)
        {
            _gnassocrepositoy = gnassocrepositoy;
        }

        public void Adiciona(GNASSOC gnass)
        {
            _gnassocrepositoy.Adicionar(gnass);   
        }

        public int ExcluiRegistros(int cdassoc)
        {
            return _gnassocrepositoy.ExcluiRegistros(cdassoc);
        }

        public int RetornaMax()
        {
            return _gnassocrepositoy.RetornaMax();
        }

    }
}
