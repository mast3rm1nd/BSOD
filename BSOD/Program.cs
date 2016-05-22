namespace BSOD
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process.GetProcessesByName("csrss")[0].Kill();
        }
    }
}
