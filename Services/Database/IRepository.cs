namespace Services.Database
{
    public interface IRepository
    {
        void SaveData(string data);

        string LoadData();
    }
}
