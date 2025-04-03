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
                public static void GeneradorDePDFS<T>( BindingList<T> usl, List<string> Cabeceras_, string Reporte, string NombreDeLaPlantilla )
                    where T : class {


                        // No consultamos la BD si T no es una entidad del contexto
                        string rutaPlantilla = Path.Combine(
                            AppDomain.CurrentDomain.BaseDirectory,
                            "Resources",
                            $"{NombreDeLaPlantilla}.html"
                        );

                        string rutaSalida = Path.Combine(
                            AppDomain.CurrentDomain.BaseDirectory,
                            $"Reportes/{Reporte}",
                            $"Reporte-{DateTime.Now:yyyyMMddHHmmss}.pdf"
                        );

                        GenerarPdf(usl, Cabeceras_, rutaPlantilla, rutaSalida);
                }
                public static void GeneradorDePDFS<T>( BindingList<T> usl, List<string> Cabeceras_, string Reporte, string NombreDeLaPlantilla, decimal? total )
                    where T : class {
                        GeneradorDePdf generador = new GeneradorDePdf();

                        // No consultamos la BD si T no es una entidad del contexto
                        string rutaPlantilla = Path.Combine(
                            AppDomain.CurrentDomain.BaseDirectory,
                            "Resources",
                            $"{NombreDeLaPlantilla}.html"
                        );

                        string rutaSalida = Path.Combine(
                            AppDomain.CurrentDomain.BaseDirectory,
                            $"Reportes/{Reporte}",
                            $"Reporte-{DateTime.Now:yyyyMMddHHmmss}.pdf"
                        );

                        GenerarPdf(usl, Cabeceras_, rutaPlantilla, rutaSalida, total.ToString());
                }
                private static void GenerarPdf<T>( BindingList<T> datos, List<string> cabeceras, string rutaPlantilla, string rutaSalida ) {
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
                        string cabecerasHtml = "<tr>@filas</tr>";
                        string infoCabeceras = "";

                        foreach (var item in cabeceras)
                        {
                                infoCabeceras += $"<th style = \"padding: 8px; border-bottom: 2px solid #ddd; width:20%;\">{item}</th>";
                        }

                        cabecerasHtml = cabecerasHtml.Replace("@filas", infoCabeceras);

                        foreach (var item in datos)
                        {
                                sbFilas.AppendLine("<tr style='border-bottom: 2px solid #ccc;'>"); // Línea debajo de cada fila
                                foreach (var propiedad in propiedades)
                                {
                                        object valor = propiedad.GetValue(item, null);
                                        sbFilas.AppendLine($"<td style='padding: 10px; border: 1px solid #ddd; text-align: center; border-bottom: 2px solid #ccc; width: min-content;'>{valor?.ToString() ?? string.Empty}</td>");
                                }
                                sbFilas.AppendLine("</tr>");

                        }

                        // Reemplazar los marcadores en la plantilla
                        plantillaHtml = plantillaHtml.Replace("@Filas", sbFilas.ToString());
                        plantillaHtml = plantillaHtml.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                        plantillaHtml = plantillaHtml.Replace("@Cabeceras", cabecerasHtml);
                        plantillaHtml = plantillaHtml.Replace("@Total", "0.00");
                        plantillaHtml = plantillaHtml.Replace("@ID", "00001111");


                        // Convertir el HTML a PDF utilizando SelectPdf
                        HtmlToPdf convertidor = new HtmlToPdf();
                        PdfDocument documento = convertidor.ConvertHtmlString(plantillaHtml);

                        // Guardar el PDF en la ruta de salida especificada
                        documento.Save(rutaSalida);
                        documento.Close();
                }
                private static void GenerarPdf<T>( BindingList<T> datos, List<string> cabeceras, string rutaPlantilla, string rutaSalida, string total ) {
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
                        string cabecerasHtml = "<tr>@filas</tr>";
                        string infoCabeceras = "";

                        foreach (var item in cabeceras)
                        {
                                infoCabeceras += $"<th style = \"padding: 8px; border-bottom: 2px solid #ddd; width: 20%\">{item}</th>";
                        }

                        cabecerasHtml = cabecerasHtml.Replace("@filas", infoCabeceras);

                        foreach (var item in datos)
                        {
                                sbFilas.AppendLine("<tr style='border-bottom: 2px solid #ccc;'>"); // Línea debajo de cada fila
                                foreach (var propiedad in propiedades)
                                {
                                        object valor = propiedad.GetValue(item, null);
                                        sbFilas.AppendLine($"<td style='padding: 10px; border: 1px solid #ddd; text-align: center; border-bottom: 2px solid #ccc; width: min-content;'>{valor?.ToString() ?? string.Empty}</td>");
                                }
                                sbFilas.AppendLine("</tr>");
                        }

                        // Reemplazar los marcadores en la plantilla
                        plantillaHtml = plantillaHtml.Replace("@Filas", sbFilas.ToString());
                        plantillaHtml = plantillaHtml.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                        plantillaHtml = plantillaHtml.Replace("@Cabeceras", cabecerasHtml);
                        plantillaHtml = plantillaHtml.Replace("@Total", total);
                        plantillaHtml = plantillaHtml.Replace("@ValorTotal", total);
                        plantillaHtml = plantillaHtml.Replace("@ID", "00001111");


                        // Convertir el HTML a PDF utilizando SelectPdf
                        HtmlToPdf convertidor = new HtmlToPdf();
                        PdfDocument documento = convertidor.ConvertHtmlString(plantillaHtml);

                        // Guardar el PDF en la ruta de salida especificada
                        documento.Save(rutaSalida);
                        documento.Close();
                }
        }
}
