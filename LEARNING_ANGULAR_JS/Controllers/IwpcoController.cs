using System.Linq;

namespace LEARNING_ANGULAR_JS.Controllers
{
	public partial class IwpcoController : System.Web.Mvc.Controller
	{
		public IwpcoController()
			: base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Index()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
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

			//Infrastructure.JsonData oJsonData =
			//	new Infrastructure.JsonData();

			//oJsonData.Data = oPerson;
			//oJsonData.DisplayMessage = true;
			//oJsonData.State = Infrastructure.Enums.JsonResultStates.Success;
			//oJsonData.MessageText = "Your person info. has been loaded successfuly";

			//return (oJsonData.GetJsonResult());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult List()
		{
			return (View());
		}

		private static System.Collections.Generic.List<Models.Person> _peopleRepository;

		private static System.Collections.Generic.List<Models.Person> PeopleRepository
		{
			get
			{
				if (_peopleRepository == null)
				{
					_peopleRepository =
						new System.Collections.Generic.List<Models.Person>();

					for (int intIndex = 1; intIndex <= 123; intIndex++)
					{
						Models.Person oPerson =
							new Models.Person()
							{
								Age = 20 + (intIndex % 30),
								IsActive = (intIndex % 2 == 0),
								LastName = "Last Name " + intIndex,
								FirstName = "First Name " + intIndex,
							};

						_peopleRepository.Add(oPerson);
					}
				}

				return (_peopleRepository);
			}
		}

		//[System.Web.Mvc.HttpPost]
		//public virtual System.Web.Mvc.JsonResult GetPeople(int? pageSize, int? pageIndex)
		//{
		//	System.Threading.Thread.Sleep(1000);

		//	if (pageSize.HasValue == false)
		//	{
		//		pageSize = 10;
		//	}

		//	if (pageIndex.HasValue == false)
		//	{
		//		pageIndex = 0;
		//	}

		//	// Create Fake Repository
		//	//System.Collections.Generic.List<Models.Person> oPeople =
		//	//	new System.Collections.Generic.List<Models.Person>();

		//	//for (int intIndex = 1; intIndex <= 123; intIndex++)
		//	//{
		//	//	Models.Person oPerson =
		//	//		new Models.Person()
		//	//		{
		//	//			Age = 20 + (intIndex % 30),
		//	//			IsActive = (intIndex % 2 == 0),
		//	//			LastName = "Last Name " + intIndex,
		//	//			FirstName = "First Name " + intIndex,
		//	//		};

		//	//	oPeople.Add(oPerson);
		//	//}
		//	// /Create Fake Repository

		//	int intTotal =
		//		PeopleRepository
		//		.Count;

		//	var varData =
		//		PeopleRepository
		//		.Skip(pageIndex.Value * pageSize.Value)
		//		.Take(pageSize.Value)
		//		;

		//	return (Json(data: new { Total = intTotal, Data = varData },
		//		behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		//}


		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.JsonResult GetPeople(ViewModels.Iwpco.GetPeopleViewModel viewModel)
		{
			System.Threading.Thread.Sleep(1000);

			var varData =
				PeopleRepository
				.AsQueryable();

			if (string.IsNullOrWhiteSpace(viewModel.FirstName) == false)
			{
				varData =
					varData
					.Where(current => current.FirstName.Contains(viewModel.FirstName));
			}

			if (string.IsNullOrWhiteSpace(viewModel.LastName) == false)
			{
				varData =
					varData
					.Where(current => current.LastName.Contains(viewModel.LastName));
			}

			if (viewModel.FromAge.HasValue)
			{
				varData =
					varData
					.Where(current => current.Age >= viewModel.FromAge.Value);
			}

			if (viewModel.ToAge.HasValue)
			{
				varData =
					varData
					.Where(current => current.Age <= viewModel.ToAge.Value);
			}

			varData =
				varData
				.OrderBy(current => current.Id);

			int intTotal =
				varData
				.Count();

			var varResult =
				varData
				.Skip(viewModel.PageIndex * viewModel.PageSize)
				.Take(viewModel.PageSize)
				.ToList()
				;

			return (Json(data: new { Total = intTotal, Data = varResult },
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpPost]
		//public System.Web.Mvc.JsonResult CreatePerson(string firstName, string lastName, int age, bool isActive)
		public virtual System.Web.Mvc.JsonResult CreatePerson(Models.Person person)
		{
			System.Threading.Thread.Sleep(5000);

			// اطلاعات این فرد را در بانک اطلاعاتی ذخیره می کنیم

			//PeopleRepository.Add(person);
			PeopleRepository.Insert(0, person);

			return (Json(data: null,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}
	}
}
