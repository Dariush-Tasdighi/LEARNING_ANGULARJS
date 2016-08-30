namespace Infrastructure
{
	public class JsonResult : System.Web.Mvc.JsonResult
	{
		public JsonResult()
		{
			Data = null;
			ContentType = null;
			RecursionLimit = null;
			MaxJsonLength = System.Int32.MaxValue;
			ContentEncoding = System.Text.Encoding.UTF8;
			JsonRequestBehavior = System.Web.Mvc.JsonRequestBehavior.AllowGet;
		}

		public JsonResult(object data)
			: this()
		{
			Data = data;
		}

		public override void ExecuteResult(System.Web.Mvc.ControllerContext context)
		{
			base.ExecuteResult(context);
		}
	}
}
