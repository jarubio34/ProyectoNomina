using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppNomina
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarDatos();
            }
        }
        public void LlenarDatos()
        {
            LayerBusinness.LayerBusinnessEmpleado oLB = new LayerBusinness.LayerBusinnessEmpleado();
            GVDatos.DataSource = oLB.MostrarEmpleados();
            GVDatos.DataBind();
        }

        protected void GVDatos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LayerBusinness.LayerBusinnessEmpleado oLB = new LayerBusinness.LayerBusinnessEmpleado();

            Int64 ID = Convert.ToInt64(GVDatos.DataKeys[e.RowIndex].Value.ToString());

            try
            {
                oLB.EliminarEmpleado(ID);
                LblMsg.Text = "Empleado Eliminado";
                LlenarDatos();
            }
            catch(Exception exc)
            {
                LblMsg.Text = exc.Message.ToString();
            }
            finally
            {
                oLB = null;
            }
        }
    }
}