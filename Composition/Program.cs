namespace Composition
{
    class Program
    {
        static void Main()
        {
            //Demonstrates the use of Composition as opposed to inheritance
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
