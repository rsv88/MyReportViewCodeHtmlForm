# MyReportViewCodeHtmlForm

<p>Agregar la referencia al proyecto</p>
<p>Cuado de Herramientas</p>
<p>Agregar nueva pestalla</p>
<p>Elegir Elemtos</p>

<p>Componetes de Net Framework</p>
<p>Examinar</p>
<p>Buscar la ddl MyReportViewCodeHtmlForm</p>
<p>Agregar</p>
<p>Se mostrara el control FrmReportViewHelp cheado</p>
<p>Aceptar</p>

<p>Luego aparece el control en cuadro de herramientas listo para arrastrar y soltar.</p>

<p>
frmReportVIewHelp1.SetCodeHTML(GetHtml);<br>
frmReportVIewHelp1.SetContentHtmlView();<br>
<p>

<code>
 public StringBuilder GetHtml
        {
            get
            {
                StringBuilder ls = new StringBuilder();
                ls.AppendLine("");
                ls.AppendLine("");
                return ls;
            }
        }
</code>

<p>Listo el contenido escrito en GetHtml se mostrara en el control</p>
