using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

public class ImpresionRecibo
{
    private DataGridView dataGrid;
    private Font fuente = new Font("Arial", 10);
    private int posicionY = 0;
    private int maxWidth = 150; // Límite de ancho para el nombre del producto

    public ImpresionRecibo(DataGridView dgv)
    {
        this.dataGrid = dgv;
    }

    public void Imprimir()
    {
        PrintDocument printDocument = new PrintDocument();
        printDocument.PrintPage += new PrintPageEventHandler(PrintPage);

        // Establecer el nombre exacto de la impresora
        printDocument.PrinterSettings.PrinterName = "80mm Series Printer";

        try
        {
            printDocument.Print();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al imprimir: " + ex.Message);
        }
    }

    private void PrintPage(object sender, PrintPageEventArgs e)
    {
        Graphics g = e.Graphics;
        int margenIzquierdo = 10;
        int margenSuperior = 20;
        int espacioLinea = 25;
        posicionY = margenSuperior;

        // Imprimir encabezado
        g.DrawString("S.E.T.E.A", fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea;
        g.DrawString("Tel: 849-581-8773", fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea;
        g.DrawString("Fecha: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"), fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea + 10;

        // Imprimir columnas
        g.DrawString("Producto", fuente, Brushes.Black, margenIzquierdo, posicionY);
        g.DrawString("P-Unidad", fuente, Brushes.Black, margenIzquierdo + 150, posicionY);
        g.DrawString("Cant", fuente, Brushes.Black, margenIzquierdo + 100, posicionY);
        g.DrawString("Total", fuente, Brushes.Black, margenIzquierdo + 220, posicionY);
        posicionY += espacioLinea;
        g.DrawString("*----------------------------------------------------*", fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea;

        // Variable para almacenar el total de la venta
        decimal totalVenta = CalcularTotalVenta();

        // Imprimir filas del DataGridView
        foreach (DataGridViewRow row in dataGrid.Rows)
        {
            if (row.Cells["Nombre Del Producto"].Value != null)
            {
                string producto = row.Cells["Nombre Del Producto"].Value.ToString();
                string cantidad = row.Cells["cantidad Producto"].Value.ToString();
                string precio = row.Cells["Precio Unidad"].Value.ToString();
                string total = row.Cells["precio Por Cantidad"].Value.ToString();

                // Limitar el nombre del producto para que no se desborde
                string nombreProductoAjustado = AjustarNombreProducto(producto, maxWidth);

                g.DrawString(nombreProductoAjustado, fuente, Brushes.Black, margenIzquierdo, posicionY);
                g.DrawString(precio, fuente, Brushes.Black, margenIzquierdo + 150, posicionY);
                g.DrawString(cantidad.PadLeft(3), fuente, Brushes.Black, margenIzquierdo + 100, posicionY); // Alinear derecha
                g.DrawString(total, fuente, Brushes.Black, margenIzquierdo + 220, posicionY);
                posicionY += espacioLinea;
            }
        }

        // Imprimir línea final
        posicionY += 10;
        g.DrawString("*----------------------------------------------------*", fuente, Brushes.Black, margenIzquierdo, posicionY);
        posicionY += espacioLinea;

        // 📌 Imprimir el total de la venta
        g.DrawString("TOTAL: " + totalVenta.ToString("C2"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, margenIzquierdo + 150, posicionY);
        posicionY += espacioLinea;

        g.DrawString("¡Donde te seteamos a nivel tecnologico!", fuente, Brushes.Black, margenIzquierdo, posicionY);
    }

    // Función para calcular el total de la venta
    private decimal CalcularTotalVenta()
    {
        decimal total = 0;
        foreach (DataGridViewRow row in dataGrid.Rows)
        {
            if (row.Cells["precio Por Cantidad"].Value != null)
            {
                if (decimal.TryParse(row.Cells["precio Por Cantidad"].Value.ToString(), out decimal totalFila))
                {
                    total += totalFila;
                }
            }
        }
        return total;
    }

    // Función para ajustar el nombre del producto para que no se desborde
    private string AjustarNombreProducto(string nombreProducto, int maxWidth)
    {
        using (Graphics g = Graphics.FromImage(new Bitmap(1, 1)))
        {
            int anchoTexto = (int)g.MeasureString(nombreProducto, fuente).Width;

            // Si el ancho excede el límite, cortar el texto
            if (anchoTexto > maxWidth - 100)
            {
                return nombreProducto.Substring(0, nombreProducto.Length / 2) + ".";
            }
            else
            {
                return nombreProducto;
            }
        }
    }
}
