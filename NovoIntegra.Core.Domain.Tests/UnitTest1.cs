using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NovoIntegra.Core.Domain.Services;

namespace NovoIntegra.Core.Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Camara Municipal de Itapevi\Documentos 1995\Secretaria Executiva\Processo Legislativo\PROCESSO LEGISLATIVO.MDB";
            string pathfile = @"C:\Camara Municipal de Itapevi\Documentos 1995\Secretaria Executiva\Processo Legislativo\";
            string connectionName = "Provider=Microsoft.Jet.OLEDB.4.0;"
              + "Data Source= " + path + " ;";

            var mdb = new MdbFileService();
            var dt = mdb.RetornaArquivo(connectionName);


            Process.Start(pathfile + dt.Rows[4].ItemArray[4].ToString());
        }
    }
}
