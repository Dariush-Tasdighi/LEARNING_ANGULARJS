namespace ViewModels.Iwpco
{
	public class GetPeopleViewModel : General.DataGridViewModel
	{
		public GetPeopleViewModel()
			: base()
		{
		}

		public int? ToAge { get; set; }

		public int? FromAge { get; set; }

		public string LastName { get; set; }

		public string FirstName { get; set; }
	}
}
