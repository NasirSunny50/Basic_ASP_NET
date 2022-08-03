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

        private List<Employee> employees = new List<Employee>();

        protected void Button_save_Click(object sender, EventArgs e)
        {
            if (ViewState["Employees"] != null)
            {
                employees = (List<Employee>)ViewState["Employees"];
            }

            //single employee receive from form
            Employee employee = new Employee();
            employee.id = Convert.ToInt32(TextBox_id.Text);
            employee.name = TextBox_name.Text;
            employee.email = TextBox_email.Text;

            //employee add to list
            employees.Add(employee);


            //add to ViewState
            ViewState["Employees"] = employees;
            TextBox_id.Text = "";
            TextBox_name.Text = "";
            TextBox_email.Text = "";

        }

        protected void Button_retrive_Click(object sender, EventArgs e)
        {
            //get the kist from viewstate
            employees = (List<Employee>)ViewState["Employees"];


            //check if employee is found by id
            int inputID = Convert.ToInt32(TextBox_id.Text);

            Employee retrieveEmployee = null;

            foreach(Employee employee in employees)
            {
                if(employee.id == inputID)
                {
                    retrieveEmployee = employee;
                    break;
                }

            }

            //if found show information

            if(retrieveEmployee != null)
            {
                TextBox_name.Text = retrieveEmployee.name;
                TextBox_email.Text = retrieveEmployee.email;
            }

        }

        protected void Button_clear_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = "";
            TextBox_name.Text = "";
            TextBox_email.Text = "";
        }
    }
}