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
        public void AlterarArquivo(string fullName)
        {
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;"
        + "Data Source= " + fullName + " ;";
            var Myconnection = new OleDbConnection(con);

            DataSet myDataSet = new DataSet();
            OleDbCommand myAccessCommand = new OleDbCommand("alter table Indices add IDCATEGORY varchar(100) ", Myconnection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);

            // Open connection
            Myconnection.Open();


            myDataAdapter.Fill(myDataSet, "Indices");
            DataTable dt = new DataTable();
            dt = myDataSet.Tables["Indices"];
            Myconnection.Close();
        }

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

        public void UpdateArquivo(string fullName, string v)
        {
            string con = "Provider=Microsoft.Jet.OLEDB.4.0;"
                    + "Data Source= " + fullName + " ;";
            var Myconnection = new OleDbConnection(con);

            DataSet myDataSet = new DataSet();
            OleDbCommand myAccessCommand = new OleDbCommand("update INDICES set IDCATEGORY = '" + v + "' ", Myconnection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);

            // Open connection
            Myconnection.Open();


            myDataAdapter.Fill(myDataSet, "Indices");
            DataTable dt = new DataTable();
            dt = myDataSet.Tables["Indices"];
            Myconnection.Close();
        }
    }
}
