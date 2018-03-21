namespace Services.Database
{
    public class StringData
    {
        public const int DefaultId = 1;

        public int Id { get; set; } = DefaultId;

        public string Data { get; set; }

        public StringData()
        {
            
        }

        public StringData(string data)
        {
            Data = data;
        }
    }
}
