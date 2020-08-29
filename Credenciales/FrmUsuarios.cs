using System;

using System.Windows.Forms;
using Credenciales;
using SpreadsheetLight;


namespace Credenciales
{

    public partial class Frm_usuarios : Form
    {
        public Frm_usuarios()
        {
            InitializeComponent();
        }
        //Esta cadena de conexion nos permite ubicar el documento
      
        public string conexion = Global_Var.conexion;

        private void Frm_usuarios_Load(object sender, EventArgs e)
        {
            Llenar();

        }



        private void Btn_Actualizar_Click(object sender, EventArgs e) => Llenar();

     

        private void Dgv_Miembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Detalles();
        }

        private void Btn_Detalles_Click(object sender, EventArgs e)
        {
            Detalles();
        }

        /*Metodos*/
        public void Detalles()
        {
            int empleado = new int();

            /*Al da clic a un elemento del dgv se alamacena su numero de columna en una 
            variable global y en una variable local,  se le suma dos a la global
            para ingresar una url en la celda correcta*/
            empleado = Dgv_Miembros.CurrentCell.RowIndex;
            Global_Var.Empleado_index = empleado + 2;


            /*Se almacenan los vaores de la fila seleccionada en variables globales*/
            Global_Var.NDSS = Dgv_Miembros.Rows[empleado].Cells[0].Value.ToString();
            Global_Var.NoNOMINA = Dgv_Miembros.Rows[empleado].Cells[1].Value.ToString();
            Global_Var.NOMBRE = Dgv_Miembros.Rows[empleado].Cells[2].Value.ToString();
            Global_Var.NOMBRE_2 = Dgv_Miembros.Rows[empleado].Cells[3].Value.ToString();
            Global_Var.APP = Dgv_Miembros.Rows[empleado].Cells[4].Value.ToString();
            Global_Var.APM = Dgv_Miembros.Rows[empleado].Cells[5].Value.ToString();
            Global_Var.RFC = Dgv_Miembros.Rows[empleado].Cells[6].Value.ToString();

            FrmDetalles_Usu frm = new FrmDetalles_Usu();

            this.Hide();
            frm.Show();
        }


        public void Llenar()
        {
            //Aqui creamos un objeto de la clase conexion_excel que es una clase creada por mi
            conexion_excel ls = new conexion_excel();
            //Aqui accedemos al metodo conectar  el cual almacena nuestra cadena de conexion en una variable global de la clase
            ls.Conectar(conexion);
            //Aqui unicamente asignamos el contenido de los datos del datagried con la funcion llenar del objeto
            Dgv_Miembros.DataSource = ls.Llenar();
        }
    }
}

   






/* SLDocument sL = new SLDocument(conexion);


  int irow = 2;
  List<MiembrosViewModel> lst = new List<MiembrosViewModel>();

  while (!string.IsNullOrEmpty(sL.GetCellValueAsString(irow,1)))
  {
      MiembrosViewModel Opersona = new MiembrosViewModel();
      Opersona.NDSS = sL.GetCellValueAsString(irow, 1);
      Opersona.NOMBRE = sL.GetCellValueAsString(irow, 2);
      Opersona.NOMBRE_2 = sL.GetCellValueAsString(irow,3);
      Opersona.APP = sL.GetCellValueAsString(irow,4);
      Opersona.APM = sL.GetCellValueAsString(irow,5);
      Opersona.APP = sL.GetCellValueAsString(irow,6);
      Opersona.RFC = sL.GetCellValueAsString(irow,7);

      lst.Add(Opersona);

      irow++;
  }*/
