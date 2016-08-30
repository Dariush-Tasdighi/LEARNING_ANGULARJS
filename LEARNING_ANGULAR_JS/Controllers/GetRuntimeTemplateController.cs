using System.Linq;

namespace LEARNING_ANGULAR_JS.Controllers
{
	public partial class GetRuntimeTemplateController : System.Web.Mvc.Controller
	{
		public GetRuntimeTemplateController()
			: base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ActionResult Index()
		{
			return (View());
		}

		public virtual System.Web.Mvc.PartialViewResult GetRuntimeTemplate()
		{
			return (PartialView());
		}
	}
}
