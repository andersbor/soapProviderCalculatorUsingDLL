using CalculatorComponent;

namespace SoapCalculatorUsingDLL
{
    // must have a reference til CalculatorComponent
    // Add Reference .... (not ServiceReference)
    public class CalculatorService : ICalculatorService
    {     
        public int Add(int a, int b)
        {
            return Calculator.Add(a, b);
        }

        public int Subtract(int a, int b)
        {
            return Calculator.Subtract(a, b);
        }

        public int Multiply(int a, int b)
        {
            return Calculator.Multiply(a, b);
        }

        public int Divide(int a, int b)
        {
            return Calculator.Divide(a, b);
        }

        public double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a + b;
        }

        public double MultiplyDoubles(double a, double b)
        {
            return a * b;
        }

        public double DivideDoubles(double a, double b)
        {
            return a / b;
        }
    }
}