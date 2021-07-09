using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormProject.UserControl;
namespace WebFormProject
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            UserInfoBoxControl userInfoBoxControl = (UserInfoBoxControl)LoadControl("~/UserControl/UserInfoBoxControl.ascx");
            userInfoBoxControl.UserName = "John Doe";
            userInfoBoxControl.UserAge = 78;
            userInfoBoxControl.UserCountry = "Spain";
            phUserInfoBox.Controls.Add(userInfoBoxControl);


        }
    }
}