using System.Linq;

namespace LEARNING_ANGULAR_JS.Controllers
{
	public class TefasController : System.Web.Mvc.Controller
	{
		public TefasController() : base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Action1()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData1()
		{
			Models.Person person = new Models.Person();

			person.Age = 44;
			person.FirstName = "Dariush";
			person.LastName = "Tasdighi";
			person.IsActive = true;

			return (Json(data: person,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Action2()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Action3()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData2()
		{
			System.Threading.Thread.Sleep(5000);

			Models.Person person = new Models.Person();

			person.Age = 44;
			person.FirstName = "Dariush";
			person.LastName = "Tasdighi";
			person.IsActive = true;

			return (Json(data: person,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Action4()
		{
			return (View());
		}
	}
}
