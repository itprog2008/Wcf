using Services;

namespace TestWcfService
{
    public class TestService : ITestService
    {
        private IWorkService _workService;

        public TestService(IWorkService workService)
        {
            _workService = workService;
        }

        public int get_num1(int a)
        {
            return _workService.GetNum(a);
        }

        public int get_num2(int a)
        {
            return _workService.GetNum(a);
        }

        public int get_num3(int a)
        {
            return _workService.GetNum(a);
        }

        public void PutData(string data)
        {
            _workService.SaveData(data);
        }

        public string GetData()
        {
            return _workService.LoadData();
        }
    }
}
