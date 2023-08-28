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
            if (!IsPostBack)
            {
                LblGame.Text = $"<h2><b>Welcome</b></h2>";

            }
        }

        protected void DDGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblGame.Text = DDGameList.Text;
            if (DDGameList.SelectedIndex == 1)
            {
                ImgGame.ImageUrl = "./Images/BG3.jpg";
            }
            else if (DDGameList.SelectedIndex == 2)
            {
                ImgGame.ImageUrl = "./Images/TombRaider.jpg";
            }
            else if (DDGameList.SelectedIndex == 3)
            {
                ImgGame.ImageUrl = "./Images/RE2.jpg";
            }
            if (DDGameList.Items.Count > 3)
            {
                DDGameList.Items.RemoveAt(0);
            }
        }
    }
}