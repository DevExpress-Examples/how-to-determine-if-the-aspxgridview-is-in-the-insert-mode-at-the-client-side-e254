﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page
{
    protected void ASPxGridView1_CustomJSProperties(object sender, DevExpress.Web.ASPxGridViewClientJSPropertiesEventArgs e) {
        e.Properties["cpIsNewRowEditing"] = (sender as ASPxGridView).IsNewRowEditing.ToString();
    }
}