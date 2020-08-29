using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credenciales
{
    /*Esta clase crea un objeto que almacena los campos que tendra cada usuario  en su ficha de trabajador y se le asignan 
     * metodos get y set para recibir y obtener datos de otras clases
    */
    public class  MiembrosViewModel
    {
        public  string NDSS { get; set; }
        public string NoNOMINA { get; set; }
        public string NOMBRE { get; set; }
        public string NOMBRE_2 { get; set; }
        public  string APP { get; set; }
        public string APM { get; set; }
        public string RFC { get; set; }
        public string FOTO { get; set; }


    }
}
