namespace ProxyPattern
{
    public class SuperSecretDatabase : ISuperSecret
    {
        private string _databaseName;

        public SuperSecretDatabase(string databaseName)
        {
            _databaseName = databaseName;
        }

        public void DisplayDatabaseName()
        {
            Console.WriteLine("Display database name: " + _databaseName);
        }
    }
}
