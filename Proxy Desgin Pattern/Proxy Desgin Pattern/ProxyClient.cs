namespace Proxy_Desgin_Pattern
{
    using System;
    using static System.Console;

    public class ProxyClient:IClient
    {
        RealClient client = new RealClient();

        public ProxyClient()
        {
            WriteLine("Proxy Client: Inititlized");
        }

        public string GetData()
        {
            return client.GetData();
        }
    }
}
