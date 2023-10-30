namespace Singleton
{
    public static class Client
    {
        public static void Execute()
        {
            var instance = ContextDb.Instance;
            instance.ExecuteQuery("SELECT * From [SomeTable]");

            instance = ContextDb.Instance;
            instance.ExecuteQuery("INSERT INTO [SomeTable]");

            instance = ContextDb.Instance;
            instance.ExecuteQuery("DELETE FROM [SomeTable]");
        }
    }
}
