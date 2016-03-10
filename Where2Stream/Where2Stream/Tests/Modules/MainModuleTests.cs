using Nancy;
using Nancy.Testing;
using NUnit.Framework;

namespace Where2Stream.Tests.Modules
{
	[TestFixture]
	public class MainModuleTests
	{
		[Test]
		public void Should_return_status_ok_when_route_exists()
		{
			// Given
			var bootstrapper = new DefaultNancyBootstrapper();
			var browser = new Browser(bootstrapper);

			// When
			var result = browser.Get("/", with => {
				with.HttpRequest();
			});

			// Then
			Assert.AreEqual(expected: HttpStatusCode.OK, actual: result.StatusCode);
			Assert.AreEqual(expected: "Hello, World!", actual: result.Body.AsString());
		}
	}
}