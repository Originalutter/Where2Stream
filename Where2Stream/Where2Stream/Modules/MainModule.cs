using Nancy;
using Nancy.Routing;

namespace Where2Stream.Modules
{
	public class MainModule : NancyModule
	{
		public MainModule()
		{
			Get["/"] = parameters => "Hello, World!";
		}
	}
}
