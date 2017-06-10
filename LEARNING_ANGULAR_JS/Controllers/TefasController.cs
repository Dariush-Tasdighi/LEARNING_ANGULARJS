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

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData3(string firstName, string lastName, int age)
		{
			System.Threading.Thread.Sleep(5000);

			Models.Person person = new Models.Person();

			person.Age = age;
			person.IsActive = false;
			person.LastName = lastName;
			person.FirstName = firstName;

			return (Json(data: person,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Action5()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData4(Models.Person person)
		{
			System.Threading.Thread.Sleep(5000);

			person.IsActive = false;

			return (Json(data: person,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Action6()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Action7()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public System.Web.Mvc.JsonResult GetData5(Infrastructure.BaseGridViewModel viewModel)
		{
			System.Threading.Thread.Sleep(500);

			var varResult =
				People;

			// Where

			int intCount =
				varResult
				.Count();

			varResult =
				varResult
				.OrderBy(current => current.Age)
				.Skip(viewModel.PageIndex * viewModel.PageSize)
				.Take(viewModel.PageSize)
				.ToList()
				;

			var varData =
				new { Data = varResult, Count = intCount };

			return (Json(data: varData,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		private static System.Collections.Generic.List<Models.Person> _people;
		private static System.Collections.Generic.List<Models.Person> People
		{
			get
			{
				if (_people == null)
				{
					_people =
						new System.Collections.Generic.List<Models.Person>();

					for (int intIndex = 1; intIndex < 125; intIndex++)
					{
						Models.Person oPerson = new Models.Person();

						oPerson.Age = (20 + intIndex) % 50;
						oPerson.FirstName = "First Name " + intIndex;
						oPerson.LastName = "Last Name " + intIndex;
						oPerson.IsActive = (intIndex % 2 == 0);

						_people.Add(oPerson);
					}
				}

				return (_people);
			}
		}
	}
}
