using LiteDB;
using System.Web.Hosting;

namespace Services.Database
{
    public class Repository : IRepository
    {
        private readonly LiteDatabase database = 
            new LiteDatabase(System.IO.Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "data.db"));

        private LiteCollection<StringData> Collection => database.GetCollection<StringData>(); 

        public void SaveData(string data)
        {
            Collection.Upsert(new StringData(data));
        }

        public string LoadData()
        {
            return Collection.FindOne(d => d.Id == StringData.DefaultId)?.Data;
        }
    }
}
