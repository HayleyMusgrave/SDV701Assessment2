using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace AdoptsSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri _baseAddress = new Uri("http://localhost:60065/");
            HttpSelfHostConfiguration config = new HttpSelfHostConfiguration(_baseAddress);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            HttpSelfHostServer server = new HttpSelfHostServer(config);
            server.OpenAsync().Wait();
            Console.WriteLine("Dragons Web-API Selfhost on " + _baseAddress);
            Console.WriteLine("ENTER to end hosting");
            Console.ReadLine();
            server.CloseAsync().Wait();
        }
    }
}
