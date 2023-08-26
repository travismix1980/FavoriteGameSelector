using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FavoriteGameSelector
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DDGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblGame.Text = DDGameList.Text;
            if(DDGameList.SelectedIndex == 1)
            {

            }
            else if (DDGameList.SelectedIndex == 2)
            {

            }
            else if(DDGameList.SelectedIndex == 3)
            {

            }
        }
    }
}