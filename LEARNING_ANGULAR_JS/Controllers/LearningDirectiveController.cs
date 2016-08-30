namespace LEARNING_ANGULAR_JS.Controllers
{
	public partial class LearningDirectiveController : System.Web.Mvc.Controller
	{
		public LearningDirectiveController()
			: base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn01()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.JsonResult GetStates()
		{
			System.Collections.Generic.List<Models.State> oStates =
				new System.Collections.Generic.List<Models.State>();

			oStates.Add(new Models.State() { Id = 1, Name = "Tehran" });
			oStates.Add(new Models.State() { Id = 2, Name = "Fars" });

			return (Json(data: oStates,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.JsonResult GetCities(int stateId)
		{
			System.Collections.Generic.List<Models.City> oCities =
				new System.Collections.Generic.List<Models.City>();

			switch (stateId)
			{
				case 1:
				{
					oCities.Add(new Models.City() { Id = 1, Name = "Tehran" });
					oCities.Add(new Models.City() { Id = 2, Name = "Karaj" });

					break;
				}

				case 2:
				{
					oCities.Add(new Models.City() { Id = 1, Name = "Shiraz" });
					oCities.Add(new Models.City() { Id = 2, Name = "Abadeh" });

					break;
				}
			}

			return (Json(data: oCities,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet));
		}
	}
}
