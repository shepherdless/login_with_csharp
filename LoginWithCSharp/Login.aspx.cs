﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace LoginWithCSharp
{
    public partial class Login : System.Web.UI.Page
    {
          

        protected void Button_3_Click1(object sender, EventArgs e)
        {
            UT_1 a = new UT_1();
            a.Logear(TextBox1.Text, TextBox2.Text);

        }
    }
    }
    
