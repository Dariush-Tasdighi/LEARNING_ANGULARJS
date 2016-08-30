using System.Linq;

namespace LEARNING_ANGULAR_JS.Controllers
{
	public partial class MapnaController : System.Web.Mvc.Controller
	{
		public MapnaController()
			: base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Index()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.JsonResult GetPerson()
		{
			System.Threading.Thread.Sleep(5000);

			Models.Person oPerson =
				new Models.Person()
				{
					Age = 20,
					IsActive = true,
					LastName = "Alavi",
					FirstName = "Ali Reza",
				};

			return (Json(data: oPerson,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult DisplayPeople()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.JsonResult GetPeople(int? pageIndex)
		{
			System.Threading.Thread.Sleep(1000);

			System.Collections.Generic.List<Models.Person> oPeople =
				new System.Collections.Generic.List<Models.Person>();

			for (int intIndex = 1; intIndex <= 100; intIndex++)
			{
				Models.Person oPerson =
					new Models.Person()
					{
						Age = (20 + intIndex) % 50,
						IsActive = (intIndex % 2 == 0),
						LastName = "Last Name " + intIndex,
						FirstName = "First Name " + intIndex,
					};

				oPeople.Add(oPerson);
			}

			if (pageIndex.HasValue == false)
			{
				pageIndex = 0;
			}

			int intTotal = oPeople.Count;

			var varPeople =
				oPeople
				.Skip(pageIndex.Value * 10)
				.Take(10)
				;

			return (Json(data: new { Data = varPeople, Total = intTotal },
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}
	}
}
