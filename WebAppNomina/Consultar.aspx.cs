using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppNomina
{
    public partial class Consultar : System.Web.UI.Page
    {
        LayerBusinness.LayerBusinnessEmpleado oLB = new LayerBusinness.LayerBusinnessEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarDatos();
            }
        }

        public void LlenarDatos()
        {
            GVDatos.DataSource = oLB.MostrarEmpleados();
            GVDatos.DataBind();
        }

    }
}