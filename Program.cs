namespace TalBar_OPP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();
            table.insertColumnNames("name", "last name");
            table.insertRow("Israel", "Israeli");
            Console.WriteLine(table.GetValue("name", 1));
        }
    }
}