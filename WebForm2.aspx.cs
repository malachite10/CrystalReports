using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace reportcrystal
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Enviar(object sender, EventArgs e)
        {
            int matricula = Convert.ToInt32(TextBox1.Text);
            String nombre = TextBox2.Text;
            int edad = Convert.ToInt32(TextBox3.Text);
            ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient();
            if( ws.InsertarDatos(matricula, nombre, edad) )
            {
                Response.Redirect( "~/WebForm1.aspx" );
            }
            else
            {
                Response.Write("Error no se pudo insertar la informacion");
            }
        }
    }
}