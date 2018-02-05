using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra
{
    public static class Library
    {
        public static void WriterLogError(Exception ex)
        {
            try
            {
                var sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + ex.Source.ToString().Trim() + ": " + ex.Message.ToString().Trim());
                sw.Flush();
                sw.Close(); 
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void WriterLogError(string msg)
        {
            try
            {
                var sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + msg);
                sw.Flush();
                sw.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
