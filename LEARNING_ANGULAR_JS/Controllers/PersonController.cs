using System.Linq;
using System.Data.Entity;

namespace LEARNING_ANGULAR_JS.Controllers
{
	public partial class PersonController : System.Web.Mvc.Controller
	{
		public PersonController()
			: base()
		{
		}


		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.JsonResult GetData()
		{
			System.Collections.Generic.List<Models.Person> oPeople =
				new System.Collections.Generic.List<Models.Person>();

			return (Json(data: oPeople, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}
	}
}
