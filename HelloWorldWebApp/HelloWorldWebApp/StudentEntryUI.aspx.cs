using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorldWebApp
{
    public partial class StudentEntryUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void button_save_Click(object sender, EventArgs e)
        {
             ViewState["name"] = textBox_name.Text;
             ViewState["email"] = textBox_email.Text;
             ViewState["roll"] = textBox_roll.Text;

            //textBox_name.Text = "";
            //textBox_email.Text = "";
            //textBox_roll.Text = "";
        }

        protected void button_retrieve_Click(object sender, EventArgs e)
        {
            textBox_name.Text = ViewState["name"].ToString();
            textBox_email.Text = ViewState["email"].ToString();
            textBox_roll.Text = ViewState["roll"].ToString();
        }
    }
}