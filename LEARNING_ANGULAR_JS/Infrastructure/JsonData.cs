namespace Infrastructure
{
	/// <summary>
	/// Version: 1.0.6
	/// Update Date: 1393/12/23
	/// Changed In Version: 1.8.3
	/// Developer: Mr. Dariush Tasdighi
	/// </summary>
	public class JsonData : System.Object
	{
		public JsonData()
		{
		}

		[System.Web.Script.Serialization.ScriptIgnore]
		public JsonData InnerJsonData { get; set; }

		public object Data { get; set; }

		public string MessageText { get; set; }

		public string MessageTitle { get; set; }

		public bool? DisplayMessage { get; set; }

		public Enums.JsonResultStates State { get; set; }

		public System.Web.Mvc.JsonResult GetJsonResult()
		{
			if (string.IsNullOrWhiteSpace(MessageTitle))
			{
				switch (State)
				{
					case Enums.JsonResultStates.Error:
					{
						MessageTitle = "Error";

						break;
					}

					case Enums.JsonResultStates.Success:
					{
						MessageTitle = "Success";

						break;
					}

					case Enums.JsonResultStates.Warning:
					{
						MessageTitle = "Warning";

						break;
					}
				}
			}

			if (string.IsNullOrWhiteSpace(MessageText))
			{
				DisplayMessage = false;
			}
			else
			{
				if (DisplayMessage.HasValue == false)
				{
					DisplayMessage = true;
				}
			}

			JsonResult oJsonResult =
				new JsonResult(data: this);

			return (oJsonResult);
		}
	}
}
