using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.pantallas
{
    public partial class Terceros: Form1
    {
        public Terceros() : base ("Proveedores")
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void Proveedores_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private void Btnconsultar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DataTable res = new DataTable();
        //        //valida campos
        //        negocio cs_negocios = new negocio();

        //        res = cs_negocios.consultar(this.txtdesc.Text, this.txtcostmi.Text, this.txtcostma.Text, txtcod.Text);

        //        if (res.Rows.Count > 0)
        //        {
        //            grwconsulta.DataSource = res;
        //        }
        //        else
        //        {
        //            MessageBox.Show("No existen registros Carlitos");
        //            grwconsulta.DataSource = null;
        //        }

        //        //consume clase de negocio


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al consultar: " + ex.Message);
        //    }
        //}

    }
}
