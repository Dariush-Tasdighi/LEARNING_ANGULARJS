namespace Infrastructure
{
	public class BaseGridViewModel : object
	{
		public BaseGridViewModel() : base()
		{
		}

		public int PageSize { get; set; }

		public int PageIndex { get; set; }

		public string SortFieldName { get; set; }

		public string SortDirection { get; set; }
	}
}
