﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormProject.UserControl
{
    public partial class EventUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string pageTitle { get; set; }
        public event EventHandler PageTitleUpdated;

        protected void btnUpdatePageTitle_Click(object sender, EventArgs e)
        {
            this.pageTitle = txtPageTitle.Text;
            if (PageTitleUpdated != null)
                PageTitleUpdated(this, EventArgs.Empty);
        }
    }
}