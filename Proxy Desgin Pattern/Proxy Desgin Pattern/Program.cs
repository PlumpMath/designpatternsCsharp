namespace Proxy_Desgin_Pattern
{
    using static System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            ProxyClient proxy = new ProxyClient();
            WriteLine($"Data from Proxy Client = {proxy.GetData()} ");
            ReadKey();
        }
    }
}
