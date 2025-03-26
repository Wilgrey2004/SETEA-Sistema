using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables; // Para Table, Row, etc.
using MigraDoc.Rendering;                  // Para PdfDocumentRenderer
using SelectPdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;

namespace SETEA_Sistema.Utilidades
{
        public class GeneradorDePdf
        {
                // string resourcesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
                //string filePath = Path.Combine(resourcesPath, "MiReporte.pdf");

                public void GenerarPdf<T>( BindingList<T> datos, List<string> cabeceras, string rutaPlantilla, string rutaSalida ) {
                        // Verificar la existencia de la plantilla HTML
                        if (!File.Exists(rutaPlantilla))
                        {
                                throw new FileNotFoundException("No se encontró la plantilla en la ruta especificada.", rutaPlantilla);
                        }

                        // Leer la plantilla HTML
                        string plantillaHtml = File.ReadAllText(rutaPlantilla);

                        // Construir las filas de la tabla
                        StringBuilder sbFilas = new StringBuilder();
                        PropertyInfo[] propiedades = typeof(T).GetProperties();

                        foreach (var item in datos)
                        {
                                sbFilas.AppendLine("<tr>");
                                foreach (var propiedad in propiedades)
                                {
                                        object valor = propiedad.GetValue(item, null);
                                        sbFilas.AppendLine($"<td>{valor?.ToString() ?? string.Empty}</td>");
                                }
                                sbFilas.AppendLine("</tr>");
                        }

                        // Reemplazar los marcadores en la plantilla
                        plantillaHtml = plantillaHtml.Replace("@Filas", sbFilas.ToString());
                        plantillaHtml = plantillaHtml.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));

                        // Convertir el HTML a PDF utilizando SelectPdf
                        HtmlToPdf convertidor = new HtmlToPdf();
                        PdfDocument documento = convertidor.ConvertHtmlString(plantillaHtml);

                        // Guardar el PDF en la ruta de salida especificada
                        documento.Save(rutaSalida);
                        documento.Close();
                }
        }
}
