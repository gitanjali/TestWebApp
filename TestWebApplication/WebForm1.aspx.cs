using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //static double zero;


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Response.Write(0 / zero == double.NaN);
                //Response.Write(0 / zero != double.NaN);
                //Response.Write(double.IsNaN(0 / zero));

            }
            catch (Exception ex)
            {

            }
        }

    }

    //public class Class1
    //{
    //    // Violation occurs because the finalizer is empty.
    //    ~Class1()
    //    {
    //    }
    //}


}