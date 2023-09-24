using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;



//----< Word Addin >----
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using KmnlkWordAddins.Helpers;
//----</ Word Addin >----

namespace KmnlkWordAddins.Ribbons
{
    public partial class ConvertWordToPdf
    {
        private void ConvertWordToPdf_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btn_SaveAsPdf_Click(object sender, RibbonControlEventArgs e)
        {
            MainHelper.SaveAsPdf();
        }

     
    }
}
