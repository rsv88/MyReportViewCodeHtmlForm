using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyReportViewCodeHtmlForm
{
    public partial class FrmReportVIewHelp : UserControl
    {
        public FrmReportVIewHelp()
        {
            InitializeComponent();
        }

        private ReportPlantilla plantilla;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        /// <summary>
        /// Generar la vista para el reporte con el codigo html
        /// </summary>
        /// <param name="codeHtml">Code HTML</param>
        public void SetContentHtmlView()
        {
            plantilla = new ReportPlantilla();
            plantilla.CodeHtml = GetHtml;
            ReportViewHtml.DocumentText = plantilla.ReportView;
            ReportViewHtml.Refresh();
        }
        private string GetHtml { get; set; }
        /// <summary>
        /// Agregar el codigo html al control
        /// </summary>
        /// <param name="codeHtml"></param>
        public void SetCodeHTML(StringBuilder codeHtml)
        {
            GetHtml = codeHtml.ToString();
        }
        /// <summary>
        /// Imprimir contenido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            ReportViewHtml.ShowPrintPreviewDialog();
        }
        /// <summary>
        /// Guardar el conetenido en html para imprimir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
           
            ReportViewHtml.ShowSaveAsDialog();
        }
    }
}
