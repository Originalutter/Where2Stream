using System;
using Nancy;
using Nancy.Hosting.Self;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			// initialize an instance of NancyHost (found in the Nancy.Hosting.Self package)
			var host = new NancyHost(new Uri("http://localhost:12345"));
			host.Start(); // start hosting
			Console.WriteLine("Started hosting");
			Console.ReadKey();
			host.Stop();  // stop hosting
		}
	}
}
