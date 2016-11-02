namespace Proxy_Desgin_Pattern
{
    using static System.Console;

    public class RealClient:IClient
    {
        string Data;

        public RealClient()
        {
            WriteLine($"Real Client: Initialized");
            Data = "I am Loki";
        }

        public string GetData()
        {
            return Data;
        }
    }
}
