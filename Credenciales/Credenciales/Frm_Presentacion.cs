using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credenciales
{
    public partial class Frm_Presentacion : Form
    {
        public OpenFileDialog open = new OpenFileDialog();

       public string conexion = "";
      
        public Frm_Presentacion()
        {
            InitializeComponent();
        }

        private void Btn_Seleccionar_Click(object sender, EventArgs e)
        {

            //Es la vairble que le pasa la cadena de conexion a la varible global
          

            //Muestra una ventana emergente de ok
            if (open.ShowDialog() == DialogResult.OK)
            {
                /*obtiene la cadena de conexion del archivo y la almacena en la variable 
                 conexion y despues la envia a la variable global conexion*/
                conexion = Path.GetFullPath(open.FileName);
                Global_Var.conexion = conexion;
                MessageBox.Show(Global_Var.conexion);

            }
      
        }

        

        private void Btn_Continuar_Click(object sender, EventArgs e)
        {
            Frm_usuarios frm = new Frm_usuarios();

            this.Hide();
            frm.Show();
        }

        private void Frm_Presentacion_Load(object sender, EventArgs e)
        {

        }

        
        }
    }

