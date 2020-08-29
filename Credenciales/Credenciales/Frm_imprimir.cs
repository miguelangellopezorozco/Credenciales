using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credenciales
{
    public partial class Frm_imprimir : Form
    {
        public Frm_imprimir()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
 
        }

        private void credenciales1_InitReport(object sender, EventArgs e)
        {

        }

        private void Frm_imprimir_Load(object sender, EventArgs e)
        {
          
            crystalReportViewer1.ReportSource = Global_Var.rp;
            Global_Var.rp.Refresh();
            crystalReportViewer1.RefreshReport();
   
          
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            FrmDetalles_Usu det = new FrmDetalles_Usu();
            this.Hide();
            det.Show();

        }
    }
}
