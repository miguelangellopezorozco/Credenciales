using System;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;


using SpreadsheetLight;

namespace Credenciales
{
    public partial class FrmDetalles_Usu : Form
    {
        public string conexion = "";
        public OpenFileDialog open = new OpenFileDialog();
        
        //agregar
        SLDocument agregar = new SLDocument(Global_Var.conexion, "MIEMBROS");
        public FrmDetalles_Usu()
        {
            InitializeComponent();
        }

        private void Btn_Foto_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                /*obtiene la cadena de conexion del archivo y la almacena en la variable 
                 conexion*/
                conexion = Path.GetFullPath(open.FileName);
                /*Se asinga la imagen al picturebox y guarda la cadena de conexion en
                 el excell*/
                PicBox_Usuario.ImageLocation = conexion;
                agregar.SetCellValue(Global_Var.Empleado_index, 8, conexion);
                agregar.Save();
            }


        }

        private void FrmDetalles_Usu_Load(object sender, EventArgs e)
        {
            /*Se carga el contenido de la celda seleccionada por medio de las variables 
             globales a la caja de texo*/
            TxtBox_NDSS.Text = Global_Var.NDSS;
            TXTBox_No.Text = Global_Var.NoNOMINA;
            TXTBox_NOMBRE.Text = Global_Var.NOMBRE;
            TXTBox_SegNombre.Text = Global_Var.NOMBRE_2;
            TXTBox_APP.Text = Global_Var.APP;
            TXTBox_APM.Text = Global_Var.APM;
            TXTBox_RFC.Text = Global_Var.RFC;


        }

        private void Btn_Act_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que deseas actualizar los datos", "Actualizar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                agregar.SetCellValue(Global_Var.Empleado_index, 1, TxtBox_NDSS.Text);
                agregar.SetCellValue(Global_Var.Empleado_index, 2, TXTBox_No.Text);
                agregar.SetCellValue(Global_Var.Empleado_index, 3, TXTBox_NOMBRE.Text);
                agregar.SetCellValue(Global_Var.Empleado_index, 4, TXTBox_SegNombre.Text);
                agregar.SetCellValue(Global_Var.Empleado_index, 5, TXTBox_APP.Text);
                agregar.SetCellValue(Global_Var.Empleado_index, 6, TXTBox_APM.Text);
                agregar.SetCellValue(Global_Var.Empleado_index, 7, TXTBox_RFC.Text);
                agregar.Save();
            }
            else
            {
                MessageBox.Show("Datos no actualizados");
            }
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Frm_usuarios frm = new Frm_usuarios();
            this.Hide();
            frm.Show();
        }

        private void Btn_Generar_Click(object sender, EventArgs e)
        {
            Code128 num = new Code128();
            
           
            Frm_imprimir imp = new Frm_imprimir();
            TextObject text = (TextObject)Global_Var.rp.ReportDefinition.Sections["Area_Nombre"].ReportObjects["Txt_Nombre"];
            TextObject nomina = (TextObject)Global_Var.rp.ReportDefinition.Sections["Area_Nombre"].ReportObjects["Txt_Nomina"];
            TextObject NSS = (TextObject)Global_Var.rp.ReportDefinition.Sections["Area_Nombre"].ReportObjects["Txt_NSS"];
            TextObject bar = (TextObject)Global_Var.rp.ReportDefinition.Sections["Area_Nombre"].ReportObjects["Txt_Barcode"];
            text.Text = TXTBox_NOMBRE.Text + " " + TXTBox_SegNombre.Text + " " + TXTBox_APP.Text + " " + TXTBox_APM.Text;
            nomina.Text = TXTBox_No.Text;
            NSS.Text = TxtBox_NDSS.Text;

            num.Encode(TXTBox_No.Text);
            bar.Text = num.code;
            
            Global_Var.rp.SetParameterValue("Image_Url",conexion);
      


 



            this.Hide();
            imp.Show();
        }
    } 
}
