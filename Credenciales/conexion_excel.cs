using System;
using System.Collections.Generic;
using SpreadsheetLight;



namespace Credenciales
{
    public class conexion_excel
    {
        //Varaible global que almacena la cadena de conexion que la clase utilizara para conectar con el excell
        public SLDocument conexion;
        //En este metodo se recibe la variable de conexion que recibe el objeto y se retorna para ser almacenada en la variable globla
        public SLDocument Conectar(string cadena_de_conexion)
        {

        conexion =new SLDocument(cadena_de_conexion );

            return conexion;
        }
        /*Este metodo es el que realiza la lectura de datos del excel y las almacena en una lista para ser  retornado y enviado
         * al objeto que lo solicite se crea una lista con la estructura de la clase MiembrosViewModel y con un while se hace una
         * lectura del documento y se obtinen datos hasta que encuentre un valor vacio estos valores se almacenan en la variable
         * Objpersona hasta que son vaciados en la lista.
         */
         public List<MiembrosViewModel> Llenar () {
 
        int irow = 2;
            List<MiembrosViewModel> lista = new List<MiembrosViewModel>();
            while (!string.IsNullOrEmpty(conexion.GetCellValueAsString(irow, 1)))
                {
         MiembrosViewModel Objpersona = new MiembrosViewModel();
                    Objpersona.NDSS = conexion.GetCellValueAsString(irow, 1);
                Objpersona.NoNOMINA = conexion.GetCellValueAsString(irow,2);
                    Objpersona.NOMBRE = conexion.GetCellValueAsString(irow, 3);
                    Objpersona.NOMBRE_2 = conexion.GetCellValueAsString(irow, 4);
                    Objpersona.APP = conexion.GetCellValueAsString(irow, 5);
                    Objpersona.APM = conexion.GetCellValueAsString(irow, 6);
                    Objpersona.RFC = conexion.GetCellValueAsString(irow, 7);
                    Objpersona.FOTO = conexion.GetCellValueAsString(irow, 8);

                lista.Add(Objpersona);
                irow++;


            }
            conexion.RenameWorksheet(SLDocument.DefaultFirstSheetName, "MIEMBROS");
            return lista;
         }

    } 
            
            
        
}
    



            
             

            
     




