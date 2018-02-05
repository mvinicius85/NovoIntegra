
using NovoIntegraInterface;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NovoIntegraInterface.Suporte

{
    public class Support
    {


        public static Form BuscaForm<T>() where T : Form
        {



            foreach (Form openForm in System.Windows.Forms.Application.OpenForms)
            {
                if (openForm.GetType() == typeof(T))
                {
                    return openForm;
                }
            }
            return Program.Container.GetInstance<T>();
        }


        public static void LimparForm(Control parent)
        {
            foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
            {
                //Verificando todos os controles 
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    ((System.Windows.Forms.TextBox)ctrControl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
                {
                    ((System.Windows.Forms.RichTextBox)ctrControl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    ((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex = -1;
                    ((System.Windows.Forms.ComboBox)ctrControl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    ((System.Windows.Forms.CheckBox)ctrControl).Checked = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    ((System.Windows.Forms.RadioButton)ctrControl).Checked = false;
                }

                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.Label)))
                {
                    string sLabel = ((System.Windows.Forms.Label)ctrControl).Name;
                    if (sLabel.Substring(0, 3) == "lbl") ((System.Windows.Forms.Label)ctrControl).Text = string.Empty;
                }

                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.DataGridView)))
                {
                    ((System.Windows.Forms.DataGridView)ctrControl).Rows.Clear();
                }



                if (ctrControl.Controls.Count > 0)
                {
                    LimparForm(ctrControl);
                }
            }
        }

        public static void StatusControls(Control parent, bool status)
        {
            foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
            {
                //Verificando todos os controles 
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    ((System.Windows.Forms.TextBox)ctrControl).Enabled = status;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
                {
                    ((System.Windows.Forms.RichTextBox)ctrControl).Enabled = status;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    ((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex = -1;
                    ((System.Windows.Forms.ComboBox)ctrControl).Enabled = status;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    ((System.Windows.Forms.CheckBox)ctrControl).Enabled = status;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    ((System.Windows.Forms.RadioButton)ctrControl).Enabled = status;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.DateTimePicker)))
                {
                    ((System.Windows.Forms.DateTimePicker)ctrControl).Enabled = status;
                }
                if (ctrControl.Controls.Count > 0)
                {
                    StatusControls(ctrControl, status);
                }
            }
        }

        public static void DataGridView_ConfigGrid(DataGridView dataGridView, bool visibleCol)
        {
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.DefaultCellStyle.Font = new Font("arial", 8);
            //  dataGridView.Columns[0].HeaderCell.Style.BackColor = Color.DarkGray;
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView.DefaultCellStyle.BackColor = Color.White;
            dataGridView.RowHeadersVisible = false;
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                col.Visible = visibleCol;
                col.ReadOnly = true;
            }
        }

        public static void DataGridView_ConfigCol(DataGridView dataGridView, string nameCol, string headerCol, int indexCol, string alignmentCol, int widthCol, DataGridViewAutoSizeColumnMode autosize)
        {
            if (widthCol == 0) widthCol = 50;

            dataGridView.Columns[nameCol].Visible = true;
            dataGridView.Columns[nameCol].DisplayIndex = indexCol;
            dataGridView.Columns[nameCol].HeaderText = headerCol;
            dataGridView.Columns[nameCol].Width = widthCol;

            dataGridView.Columns[nameCol].AutoSizeMode = autosize;
            dataGridView.Columns[nameCol].SortMode = DataGridViewColumnSortMode.Automatic;

            if (alignmentCol == "D" || alignmentCol == "R") dataGridView.Columns[nameCol].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            if (alignmentCol == "E" || alignmentCol == "L") dataGridView.Columns[nameCol].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            if (alignmentCol == "C" || alignmentCol == "M") dataGridView.Columns[nameCol].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        //public static void ShowMessage(string message, MessageBoxButtons button, MessageBoxIcon icon)
        //{

        //    MessageBox.Show(SIMMA.Application.ViewModels.Legado.User.userativo.nome_abreviado.ToString() + "," + "\r" + message,
        //                     "SIMMA - FISCAL/CONTÁBIL",
        //                     button,
        //                     icon
        //                     );

        //}
        //public static void RetornarAcao(ValidationResult validationResult, MessageBoxIcon icon, Form form)
        //{
        //    frmMsgSistema frm = new frmMsgSistema(validationResult, icon);
        //    frm.MdiParent = form.MdiParent;
        //    frm.Show();
        //}
        //public static void RetornarAcao(string msg, MessageBoxIcon icon, Form form)
        //{
        //    frmMsgSistema frm = new frmMsgSistema(msg, icon);
        //    frm.MdiParent = form.MdiParent;
        //    frm.Show();
        //}

        public static void SalvarRTF(RichTextBox rtfArqruivo)
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog nomeArqruivo = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            nomeArqruivo.DefaultExt = "*.rtf";
            nomeArqruivo.Filter = "RTF Files|*.rtf";

            // Determine if the user selected a file name from the saveFileDialog.
            if (nomeArqruivo.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               nomeArqruivo.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                rtfArqruivo.SaveFile(nomeArqruivo.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        public static void SalvarPDF(RichTextBox rtfArqruivo)
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog nomeArqruivo = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            nomeArqruivo.DefaultExt = "*.pdf";
            nomeArqruivo.Filter = "PDF Arquivos|*.pdf";

            // Determine if the user selected a file name from the saveFileDialog.
            if (nomeArqruivo.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               nomeArqruivo.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                rtfArqruivo.SaveFile(nomeArqruivo.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        //public static void TrataException(Exception erro, Form form)
        //{
        //    var retorno = new ValidationResult();
        //    retorno.Errors.Add(new ValidationFailure("", erro.GetBaseException().Message));
        //    var ex = erro.LogExpectionConvertJson(SIMMA.Application.ViewModels.Legado.User.userativo.cod_usuario.ToString());
        //    var email = new MessageServices();
        //    System.Text.StringBuilder msg = new System.Text.StringBuilder();
        //    //msg.Append()

        //    email.SendEmail("marcos.macedo@rommanel.com.br", "Erro", ex);



        //    Support.RetornarAcao(retorno, MessageBoxIcon.Error, form);
        //    form.Cursor = Cursors.Default;
        //}

    }


    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "RAW Document";
            // Win7
            di.pDataType = "RAW";

            // Win8+
            // di.pDataType = "XPS_PASS";

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendFileToPrinter(string szPrinterName, string szFileName)
        {
            // Open the file.
            FileStream fs = new FileStream(szFileName, FileMode.Open);
            // Create a BinaryReader on the file.
            BinaryReader br = new BinaryReader(fs);
            // Dim an array of bytes big enough to hold the file's contents.
            Byte[] bytes = new Byte[fs.Length];
            bool bSuccess = false;
            // Your unmanaged pointer.
            IntPtr pUnmanagedBytes = new IntPtr(0);
            int nLength;

            nLength = Convert.ToInt32(fs.Length);
            // Read the contents of the file into the array.
            bytes = br.ReadBytes(nLength);
            // Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
            // Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
            // Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
            // Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
            fs.Close();
            fs.Dispose();
            fs = null;
            return bSuccess;
        }
        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }


    }














}
