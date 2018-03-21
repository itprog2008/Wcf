namespace Services
{
    public interface IWorkService
    {
        int GetNum(int a);

        void SaveData(string data);

        string LoadData();
    }
}
