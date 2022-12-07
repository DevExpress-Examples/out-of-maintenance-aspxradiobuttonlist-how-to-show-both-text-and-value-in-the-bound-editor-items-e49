using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void radioButtonList_DataBound(object sender, EventArgs e)
    {
        ASPxRadioButtonList rbl = sender as ASPxRadioButtonList;
        foreach (ListEditItem item in rbl.Items)
        {
            item.Text = string.Format("{0} ({1})", item.Text, item.Value);
        }
    }
}