using System;

namespace _03_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
           double dummy = 12;
           int tip = 20;
           int tax = 8; 

            double meal_cost = Convert.ToDouble(dummy);
            int tip_percent = Convert.ToInt32(tip);
            int tax_percent = Convert.ToInt32(tax);

            double tipCalc = meal_cost * (tip_percent/100.0);
            double taxCalc = meal_cost * (tax_percent/100.0);
            double result = meal_cost + tipCalc +taxCalc;       
            
            Console.WriteLine(result);
        }


        public void DoSomething()
        {
        }
    }
}
