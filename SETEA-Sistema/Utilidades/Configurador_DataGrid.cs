using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SETEA_Sistema.Utilidades
{
        internal class Configurador_DataGrid
        {
                public static void ConfiguracionDelDataGrid( DataGridView MyDataProductosCaja ) {
                        MyDataProductosCaja.ColumnHeadersVisible = true;
                        MyDataProductosCaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        MyDataProductosCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                        MyDataProductosCaja.ColumnHeadersHeight = 45;
                }
                public static void ConfiguracionDelDataGrid( DataGridView MyDataProductosCaja, int Cabeceras ) {
                        MyDataProductosCaja.ColumnHeadersVisible = true;
                        MyDataProductosCaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        MyDataProductosCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                        MyDataProductosCaja.ColumnHeadersHeight = Cabeceras;
                }
        }
}
