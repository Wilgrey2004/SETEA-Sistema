namespace SETEA_Sistema.Entidades
{
        public class CodigosProductosShowModels1
        {
                public int ID_Del_Codigo { get; set; }
                public string Codigo { get; set; }
                public int ID_Del_Producto { get; set; }
                public string Nombre_Del_Producto { get; set; }
                public decimal? Precio_Unidad { get; set; }
                public override string ToString() {
                        return $"N: *{Nombre_Del_Producto}* -C: *{Codigo}* -PU: *{Precio_Unidad}*";
                }

        }
}
