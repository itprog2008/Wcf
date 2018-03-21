using System.ServiceModel;

namespace TestWcfService
{
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        int get_num1(int a);

        [OperationContract]
        int get_num2(int a);

        [OperationContract]
        int get_num3(int a);

        [OperationContract]
        void PutData(string data);

        [OperationContract]
        string GetData();
    }
}
