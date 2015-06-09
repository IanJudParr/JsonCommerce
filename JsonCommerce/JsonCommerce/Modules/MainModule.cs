using Nancy;

namespace JsonCommerce.Modules
{
	public class MainModule : NancyModule 
	{
		public MainModule()
		{
			Get["/"] = _ => View["Index.cshtml"];
		}
	}
}