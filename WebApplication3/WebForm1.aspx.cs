using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Label1.Text = "Enter UserName";
            }
            else if (TextBox2.Text == "")
            {
                Label2.Text = "Enter Password";
            }
            else
            {
                if (TextBox1.Text == "Nikita" && TextBox2.Text == "1212")
                {
                    Label3.Text = "Login Success";
                }
                else
                {
                    Label3.Text = "Invalid Name or Password";
                }
            }
        }

       
    }
}