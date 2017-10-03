using System.ServiceModel;

namespace SoapCalculatorUsingDLL
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        int Add(int a, int b);
        [OperationContract]
        int Subtract(int a, int b);
        [OperationContract]
        int Multiply(int a, int b);
        [OperationContract]
        int Divide(int a, int b);

        [OperationContract]
        // SOAP does not accept overloaded method names
        double AddDoubles(double a, double b);

        [OperationContract(Name = "SubtractDoubles")]
        // Another way to avoid overloaded methods names in SOAP
        double Subtract(double a, double b);

        [OperationContract]
        double MultiplyDoubles(double a, double b);

        [OperationContract]
        double DivideDoubles(double a, double b);
    }
}