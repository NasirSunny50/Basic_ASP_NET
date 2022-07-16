using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorldWebApp
{
    public partial class CalculatorUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                    
        }

        protected void button_add_Click(object sender, EventArgs e)
        {
            Double result = Double.Parse(textBox_firstNumber.Text) + Double.Parse(textBox_secondNumber.Text);
            label_result.Text = result.ToString();
        }

        protected void button_sub_Click1(object sender, EventArgs e)
        {
            Double result = Double.Parse(textBox_firstNumber.Text) - Double.Parse(textBox_secondNumber.Text);
            label_result.Text = result.ToString();
        }

        protected void button_mul_Click1(object sender, EventArgs e)
        {
            Double result = Double.Parse(textBox_firstNumber.Text) * Double.Parse(textBox_secondNumber.Text);
            label_result.Text = result.ToString();
        }

        protected void button_div_Click1(object sender, EventArgs e)
        {
            Double result = Double.Parse(textBox_firstNumber.Text) / Double.Parse(textBox_secondNumber.Text);
            label_result.Text = result.ToString();
        }
    }
}