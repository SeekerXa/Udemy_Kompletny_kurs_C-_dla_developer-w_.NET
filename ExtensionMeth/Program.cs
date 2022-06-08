namespace ExtensionMeth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime before = now.Subtract(new TimeSpan(7, 0, 0, 0));
            DateTime after = now.AddDays(7);
            Utils.IsDateBetwen(now, before, after);

            now.IsBetwen(before, after);    
        }
    }
}