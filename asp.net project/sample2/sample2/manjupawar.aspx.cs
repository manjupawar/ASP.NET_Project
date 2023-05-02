using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;


namespace sample2
{
    public partial class manjupawar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Bal d1 = new Bal();
            d1.InsertPartyAddress(txtname.Text, txtaddr.Text);
            lblmsg.Text = "Done";
        }
    }
}