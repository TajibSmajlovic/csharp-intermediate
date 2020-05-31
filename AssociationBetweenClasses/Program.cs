namespace AssociationBetweenClasses
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();

            var logger = new Logger();
            var migration = new DbMigrator(logger);

            migration.Migrate();
        }
    }
}