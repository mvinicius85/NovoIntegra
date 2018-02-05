using NovoIntegra.Core.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Core.Domain.Services
{
    public class MdbFileService : IMdbFileService
    {
        public DataTable RetornaArquivo(string path)
        {
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;"
                    + "Data Source= " + path + " ;";
            var Myconnection = new OleDbConnection(con);

            DataSet myDataSet = new DataSet();
            OleDbCommand myAccessCommand = new OleDbCommand("select * from Indices", Myconnection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);

            // Open connection
            Myconnection.Open();

            myDataAdapter.Fill(myDataSet, "Indices");
            DataTable dt = new DataTable();
            dt = myDataSet.Tables["Indices"];
            Myconnection.Close();
            return dt;
        }
    }
}
