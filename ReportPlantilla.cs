using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReportViewCodeHtmlForm
{
    public class ReportPlantilla
    {
        public string CodeHtml { get; set; }

        public string ReportView { get {
                return CodeHtml.ToString();
            }
        }
    }
}
