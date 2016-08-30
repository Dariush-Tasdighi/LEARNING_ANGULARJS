using System.Linq;

namespace LEARNING_ANGULAR_JS.Controllers
{
	public partial class LearningSpaController : System.Web.Mvc.Controller
	{
		public LearningSpaController()
			: base()
		{
		}

		[System.Web.Mvc.HttpGet]
		//[System.Web.Mvc.OutputCache(Duration = 100000)]
		public virtual System.Web.Mvc.PartialViewResult GetPartialView1()
		{
			return (PartialView());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Index()
		{
			return (View());
		}

		private static System.Collections.Generic.List<Models.Person> _people;
		public static System.Collections.Generic.List<Models.Person> People
		{
			get
			{
				if (_people == null)
				{
					_people =
						new System.Collections.Generic.List<Models.Person>();

					for (int intIndex = 1; intIndex <= 5; intIndex++)
					{
						Models.Person oPerson =
							new Models.Person()
							{
								Age = 20 + intIndex,
								LastName = "Last Name " + (intIndex + 1),
								FirstName = "First Name " + (intIndex + 1),
							};

						_people.Add(oPerson);
					}
				}

				return (_people);
			}
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.JsonResult GetPeople()
		{
			return (Json(data: People,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.JsonResult GetPerson(System.Guid Id)
		{
			Models.Person oPerson =
				People
				.Where(current => current.Id == Id)
				.FirstOrDefault();

			return (Json(data: oPerson,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.PartialViewResult GetEditView()
		{
			return (PartialView(viewName: "EditView"));
		}
	}
}
