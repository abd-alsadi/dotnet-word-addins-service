using Word=Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkWordAddins.Helpers
{
    public class MainHelper
    {
        public static void SaveAsPdf()
        {
            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            string sfileName_Document = doc.Name;
            string sPath = doc.Path;
            if (sPath == "" || sPath == null)
            {
                sPath = desktopFolder;
            }
            string sFullpath_pdf = sPath + "\\" + sfileName_Document + ".pdf";
            doc.ExportAsFixedFormat(sFullpath_pdf, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
        }
    }
}
