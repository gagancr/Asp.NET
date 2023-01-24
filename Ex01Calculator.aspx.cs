using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class Ex01Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            var v1 = double.Parse(txtFirstVal.Text);
            var v2 = double.Parse(txtSecondVal.Text);
            var operation = dpList.SelectedValue;
            var result = getResult(v1, v2, operation);
            lblDisplay.Text = $"The result of {operation} Operation of {v1} and {v2} is {result}";


        }
        private double getResult(double v1,double v2,string operaion)
        {
            switch (operaion)
            {
                case "Addition":
                    return v1 + v2;

                case "Subtraction":
                    return v1 - v2;
                case "Multiplication":
                    return v1 * v2;
                case "Division":
                    return v1 / v2;
                default:
                    break;

            }
            return 0;
        }
    }
}