using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credenciales
{
   public static class Global_Var
    {
        public static string conexion { get; set; }

        public static string conexion_foto { get; set; }
        public static OpenFileDialog open { get; set; }
        public static int Empleado_index { get; set; }


        public static string NDSS { get; set; }
        public static string NoNOMINA { get; set; }
        public static string NOMBRE { get; set; }
        public static string NOMBRE_2 { get; set; }
        public static string APP { get; set; }
        public static string APM { get; set; }
        public static string RFC { get; set; }

        public static CrystalDecisions.CrystalReports.Engine.ReportDocument rp = new credenciales();
    }
}

