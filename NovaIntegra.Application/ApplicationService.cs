using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaIntegra.Application
{
    public class ApplicationService
    {
        private readonly NovoIntegra.Documento.Infra.Data.Interfaces.IUnitOfWork _uowDocumento;

        private bool beginStartDocumento;

        public ApplicationService(NovoIntegra.Documento.Infra.Data.Interfaces.IUnitOfWork uowDocumento)
        {
            _uowDocumento = uowDocumento;
        }


        public void BeginDocumentoTransaction()
        {
            if (_uowDocumento != null)
            {
                _uowDocumento.BeginTransaction();
                beginStartDocumento = true;
            }
        }

        public int CommitDocumento()
        {
            if (beginStartDocumento)
            {
                beginStartDocumento = false;
                return _uowDocumento.Commit();
            }
            else
                throw new System.ArgumentException("Transação do Documento não foi iniciada!");
        }




        public void BeginAllTransaction()
        {

            BeginDocumentoTransaction();
            // 
        }
   
        public int CommitAll()
        {

            int commit = 0;

            if (_uowDocumento != null)
                commit += CommitDocumento();

            return commit;
        }

        public void DisposeContexto()
        {

            _uowDocumento.DisposeContexto();

        }

        public void DisposeContextoAsync()
        {
            Task.Run(() => _uowDocumento.DisposeContexto());
        }

        public void DisposeAlt()
        {
            _uowDocumento.DisposeAdd();
        }
        public void DisposeAdd()
        {
            _uowDocumento.DisposeAdd();
        }


        //public void LogDocumento(object obj, EventType type)
        //{
        //    Task.Run(() =>
        //    {

        //        var keyNames = _uowDocumento.GetPrimearyKey(obj);

        //        if (keyNames != null)
        //        {
        //            var value = obj.GetType().GetProperty(keyNames[0]).GetValue(obj);
        //            if (value.GetType() == typeof(Guid))
        //                obj.LogEntity((Guid)value, type, Core.Domain.Entities.User.UserAtivo.CodigoUsuario.ToString());
        //            else
        //                obj.LogEntity(value.ToString(), type, Core.Domain.Entities.User.UserAtivo.CodigoUsuario.ToString());

        //        }
        //    });

        //}


    }
}
