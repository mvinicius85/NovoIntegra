using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Core.Domain.Util

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

        public static void WriterLogEntry(string msg)
        {
            string source = "ServicoIntegracao";
            string log = "Application";
            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, log);
            }
            EventLog.WriteEntry(source, msg,
                EventLogEntryType.Warning);
        }

        public static void WriterLogEntry(Exception ex)
        { }
    }
}
