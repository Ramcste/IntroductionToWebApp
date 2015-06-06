using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntroductionWebApp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private Calculator calculator = new Calculator();
        protected void addButton_OnClick(object sender, EventArgs e)
        {
            calculator.FirstNumber = decimal.Parse(firstNumberTextBox.Text);
            calculator.SecondNumber = decimal.Parse(secondNumberTextBox.Text);
            calculator.Result = calculator.Add(calculator.FirstNumber,calculator.SecondNumber);
            resultTextBox.Text = calculator.Result.ToString();
           
        }

        protected void subtractButton_OnClick(object sender, EventArgs e)
        {
            calculator.FirstNumber = decimal.Parse(firstNumberTextBox.Text);
            calculator.SecondNumber = decimal.Parse(secondNumberTextBox.Text);
            calculator.Result = calculator.Subtract(calculator.FirstNumber, calculator.SecondNumber);
            resultTextBox.Text = calculator.Result.ToString();
           

        }

        protected void multiplyButton_OnClick_(object sender, EventArgs e)
        {
            calculator.FirstNumber = decimal.Parse(firstNumberTextBox.Text);
            calculator.SecondNumber = decimal.Parse(secondNumberTextBox.Text);
            calculator.Result = calculator.Multiply(calculator.FirstNumber, calculator.SecondNumber);
            resultTextBox.Text = calculator.Result.ToString();
           

        }

        protected void divisionButton_OnClick(object sender, EventArgs e)
        {
            calculator.FirstNumber = decimal.Parse(firstNumberTextBox.Text);
            calculator.SecondNumber = decimal.Parse(secondNumberTextBox.Text);
            calculator.Result = calculator.Division(calculator.FirstNumber, calculator.SecondNumber);
            resultTextBox.Text = calculator.Result.ToString();
           

        }
    }
}