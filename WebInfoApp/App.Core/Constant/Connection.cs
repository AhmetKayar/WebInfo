namespace App.Core.Constant
{
    public static class Connection
    {
        private static string azure =
                "Server=tcp:boyut.database.windows.net,1433;Initial Catalog=WebInfo;Persist Security Info=False;User ID=webinfo;Password=201408As;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30"
            ;

        private static string local =
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebInfo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            ;
        public static string ConnectionString { get; } = azure;
    }
}
