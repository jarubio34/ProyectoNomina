using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppNomina
{
    public partial class CalcularSueldos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarDatos();
        }

        public void LlenarDatos()
        {
            LayerBusinness.LayerBusinnessEmpleado oLB = new LayerBusinness.LayerBusinnessEmpleado();
            GVDatos.DataSource = oLB.CalcularSueldoEmpleados();
            GVDatos.DataBind();
        }
    }
}