using System.Linq;
using System.Data.Entity;

namespace LEARNING_ANGULAR_JS.Controllers
{
	public partial class HomeController : System.Web.Mvc.Controller
	{
		public HomeController()
			: base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Index()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn1000()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn1010()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.JsonResult GetData1000()
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

			//Newtonsoft.Json.JsonSerializerSettings

			//System.Web.Http.Results

			//return (Json(oPerson, JsonSerializerSettings));

			return (Json(data: oPerson,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn1020()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn1030()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn1035()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.JsonResult GetData1010()
		{
			System.Threading.Thread.Sleep(5000);

			System.Collections.Generic.List<Models.Person> oPeople =
				new System.Collections.Generic.List<Models.Person>();

			for (int intIndex = 1; intIndex <= 10; intIndex++)
			{
				Models.Person oPerson =
					new Models.Person()
					{
						Age = 20 + intIndex,
						IsActive = (intIndex % 2 == 0),
						LastName =
							string.Format("Last Name ({0})", intIndex),
						FirstName =
							string.Format("First Name ({0})", intIndex),
					};

				oPeople.Add(oPerson);
			}

			return (Json(data: oPeople,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn1040()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn1050()
		{
			return (View());
		}

		//[System.Web.Mvc.HttpPost]
		//public virtual System.Web.Mvc.JsonResult SetData1000(string firstName, string lastName, int age, bool isActive)
		//{
		//	System.Threading.Thread.Sleep(5000);

		//	Models.Person oPerson =
		//		new Models.Person();

		//	oPerson.Age = age;
		//	oPerson.IsActive = isActive;
		//	oPerson.LastName = lastName;
		//	oPerson.FirstName = firstName;

		//	// را در بانک اطلاعاتی ذخيره می کنيم person اطلاعات

		//	return (Json(data: person,
		//		behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		//}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.JsonResult SetData1000(Models.Person person)
		{
			System.Threading.Thread.Sleep(5000);

			// را در بانک اطلاعاتی ذخيره می کنيم person اطلاعات

			return (Json(data: person,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn1060()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.JsonResult SetData1010(Models.Person person)
		{
			System.Threading.Thread.Sleep(5000);

			// ذخيره سازی اطلاعات شخص در بانک اطلاعاتی

			return (Json(data: person,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.JsonResult Delete1000(System.Guid id)
		{
			System.Threading.Thread.Sleep(5000);

			// رکورد مورد نظر را از بانک اطلاعاتی حذف می کنيم

			return (Json(data: true, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
			//return (Json(data: false, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn1070()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.JsonResult GetData1020(int id)
		{
			System.Threading.Thread.Sleep(5000);

			Infrastructure.JsonData oJsonData =
				new Infrastructure.JsonData();

			switch (id)
			{
				case 1:
				{
					Models.Person oPerson =
						new Models.Person()
						{
							Age = 20,
							IsActive = true,
							LastName = "Alavi",
							FirstName = "Ali Reza",
						};

					oJsonData.Data = oPerson;
					oJsonData.DisplayMessage = false;
					oJsonData.State = Infrastructure.Enums.JsonResultStates.Success;

					break;
				}

				case 2:
				{
					System.Collections.Generic.List<Models.Person> oPeople =
						new System.Collections.Generic.List<Models.Person>();

					for (int intIndex = 1; intIndex <= 10; intIndex++)
					{
						Models.Person oPerson =
							new Models.Person()
							{
								Age = 20 + intIndex,
								IsActive = (intIndex % 2 == 0),
								LastName =
									string.Format("Last Name ({0})", intIndex),
								FirstName =
									string.Format("First Name ({0})", intIndex),
							};

						oPeople.Add(oPerson);
					}

					oJsonData.Data = oPeople;

					oJsonData.DisplayMessage = true;
					oJsonData.MessageText = "All of people sent successfully.";
					oJsonData.State = Infrastructure.Enums.JsonResultStates.Success;

					break;
				}

				case 3:
				{
					oJsonData.Data = null;
					oJsonData.DisplayMessage = true;
					oJsonData.MessageText =
						"از اين اطاعات در جای ديگری استفاده شده است، لذا شما قادر به حذف آن نمی باشيد";
					oJsonData.State = Infrastructure.Enums.JsonResultStates.Error;

					break;
				}

				case 4:
				{
					break;
				}

				default:
				{
					break;
				}
			}

			return (oJsonData.GetJsonResult());
		}
	}
}
