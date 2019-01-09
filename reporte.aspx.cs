using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace reportcrystal
{
    public partial class reporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportDocument reporte = new ReportDocument();
            ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient();
            if( )
            {
                reporte.Load( Context.Server.MapPath("~/reporte.rpt"));
                reporte.SetDataSource(ws.MostrarDatos());
                CrystalReportViewer1.ReportSource = reporte;
            }
        }
    }
}