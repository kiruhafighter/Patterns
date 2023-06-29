namespace ProxyPattern
{
    public class SuperSecretDatabaseProxy : ISuperSecret
    {
        private SuperSecretDatabase superSecretDatabase;
        private string databaseName;
        private string password;

        public SuperSecretDatabaseProxy(string databaseName, string password)
        {
            this.databaseName = databaseName;
            this.password = password;
        }

        public void DisplayDatabaseName()
        {
            if (password.Equals("Password"))
            {
                if(superSecretDatabase == null)
                {
                    superSecretDatabase = new SuperSecretDatabase(databaseName);
                }
                superSecretDatabase.DisplayDatabaseName();
            }
        }
    }
}
