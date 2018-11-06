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
    public partial class Proveedores : Form1
    {
        public Proveedores() : base ("Proveedores")
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable res = new DataTable();
                //valida campos
                negocio cs_negocios = new negocio();

                res = cs_negocios.consultar(this.txtdesc.Text, this.txtcostmi.Text, this.txtcostma.Text, txtcod.Text, txtvar.Text);

                if (res.Rows.Count > 0)
                {
                    grwconsulta.DataSource = res;
                }
                else
                {
                    MessageBox.Show("No existen registros Carlitos");
                    grwconsulta.DataSource = null;
                }
                
                //consume clase de negocio
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
            }
        }

    }
}
