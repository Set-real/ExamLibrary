namespace LibraryFromWorkToSql.Configurations
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Server=NOTEBOOK\SQLEXPRESS01;Database=testing;Trusted_Connection=True;TrustServerCertificate=true";
    }
}
