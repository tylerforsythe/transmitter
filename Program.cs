using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace Transmitter
{
    class Program
    {
        static void Main(string[] args) {
            string baseAddress = "http://localhost:9000/"; 

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress)) {
                FetchTest(baseAddress);

                Console.WriteLine("Waiting for key to exit...");

                Console.ReadLine();
            } 

        }

        private static void FetchTest(string baseAddress) {
            // Create HttpClient and make a request to api/values 
            HttpClient client = new HttpClient();

            var response = client.GetAsync(baseAddress + "api/values").Result;

            Console.WriteLine(response);
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
        }
    }
}
