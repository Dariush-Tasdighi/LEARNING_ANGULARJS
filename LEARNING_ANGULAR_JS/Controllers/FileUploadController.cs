using System.Linq;

namespace LEARNING_ANGULAR_JS.Controllers
{
	public partial class FileUploadController : System.Web.Mvc.Controller
	{
		public FileUploadController()
			: base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Index()
		{
			// Install-Package angular-file-upload

			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult List()
		{
			return (View());
		}

		[System.Web.Mvc.HttpPost]
		public void ManageUploadedFiles(string nationalCode)
		{
			if (Request.Files == null)
			{
				return;
			}

			if (Request.Files.Count == 0)
			{
				return;
			}

			System.Web.HttpPostedFileBase oHttpPostedFile = Request.Files[0];

			if (oHttpPostedFile.ContentLength == 0)
			{
				return;
			}
		}
	}
}
