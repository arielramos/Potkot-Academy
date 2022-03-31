using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Potkot_Academy
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OracleConnection conexion = new OracleConnection("DATA SOURCE=ORCL; PASSWORD=rXFHoax8; USER ID = POTKOT_ADMIN;");
            conexion.Open();

            string script = "alert(\"Conexión abierta!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
            conexion.Close();

            
        }
    }
}