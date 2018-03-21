using Services.Database;

namespace Services
{
    public class WorkService : IWorkService
    {
        private IRepository _repository;

        public WorkService(IRepository repository)
        {
            _repository = repository;
        }

        public int GetNum(int a)
        {
            switch (a)
            {
                case int b when b > 1000:
                    return a * 4;
                case int b when b > 100:
                    return a * 3;
                case int b when b > 10:
                    return a * 2;
                default:
                    return a;
            }
        }

        public void SaveData(string data)
        {
            _repository.SaveData(data);
        }

        public string LoadData()
        {
            return _repository.LoadData();
        }
    }
}
