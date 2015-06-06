using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroductionWebApp
{
    public class Calculator
    {
        public decimal FirstNumber { get; set; }

        public decimal SecondNumber { get; set; }

        public decimal Result { get; set; }


        public decimal Add(decimal firstNumber,decimal secondNumber) 
        {
            return firstNumber + secondNumber;
        }

        public decimal Subtract(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public decimal Multiply(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public decimal Division(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}