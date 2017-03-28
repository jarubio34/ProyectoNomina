using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppNomina
{
    public partial class Editar : System.Web.UI.Page
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

        protected void GVDatos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GVDatos.EditIndex = -1;
            LlenarDatos();
        }

        protected void GVDatos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GVDatos.EditIndex = e.NewEditIndex;
            LlenarDatos();
        }

        protected void GVDatos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            LayerBusinness.LayerBusinnessEmpleado oLB = new LayerBusinness.LayerBusinnessEmpleado();

            Int64 ID = Convert.ToInt64(GVDatos.DataKeys[e.RowIndex].Value.ToString());

            int result = 0;

            GridViewRow row = GVDatos.Rows[e.RowIndex];
            TextBox TA = (TextBox)row.FindControl("TxtApellidos");
            TextBox TN = (TextBox)row.FindControl("TxtNombres");
            TextBox TS = (TextBox)row.FindControl("TxtHoras");
            TextBox TH = (TextBox)row.FindControl("TxtSueldo");

            try
            {
                result = oLB.EditarEmpleado(ID, TA.Text, TN.Text, Convert.ToDouble(TS.Text), Convert.ToDouble(TH.Text));
                if (result > 0)
                {
                    LblMsg.Text = "Empleado Editado";
                }
                else
                {
                    LblMsg.Text = "Empleado NO Editado";
                }
            }
            catch (Exception exc)
            {
                LblMsg.Text = exc.Message.ToString();
            }
            finally
            {
                oLB = null;
            }
            GVDatos.EditIndex = -1;
            LlenarDatos();
        }
    }
}