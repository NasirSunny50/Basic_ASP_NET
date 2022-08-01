using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserDefinedTypeApp
{
    public partial class EmployeeEntryUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        Employee employee = null;

        protected void Button_save_Click(object sender, EventArgs e)
        {
            employee = new Employee();

            employee.id = Convert.ToInt32(TextBox_id.Text);
            employee.name = TextBox_name.Text;
            employee.email = TextBox_email.Text;

            TextBox_id.Text = "";
            TextBox_name.Text = "";
            TextBox_email.Text = "";

        }

        protected void Button_retrive_Click(object sender, EventArgs e)
        {

        }
    }
}