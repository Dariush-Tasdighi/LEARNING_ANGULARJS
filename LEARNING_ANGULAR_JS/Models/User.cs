namespace Models
{
	public class User : BaseEntity
	{
		public User()
		{
		}

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "Username")]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessage = "{0} is required!")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20, MinimumLength = 6, ErrorMessage = "The length of {0} should be between {1} and {2}!")]
		public string Username { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "Password")]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessage = "{0} is required!")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20, MinimumLength = 8, ErrorMessage = "The length of {0} should be between {1} and {2}!")]
		public string Password { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "Confirm Password")]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessage = "{0} is required!")]

		[System.ComponentModel.DataAnnotations.Compare
			(otherProperty: "Password", ErrorMessage = "{0} is not equal to {1}!")]
		public string ConfirmPassword { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(Name = "Email Address")]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessage = "{0} is required!")]

		[System.ComponentModel.DataAnnotations.DataType
			(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 250, MinimumLength = 5, ErrorMessage = "The length of {0} should be between {1} and {2}!")]
		public string EmailAddress { get; set; }
		// **********

		// **********
		[System.ComponentModel.DisplayName
			("Confirm Email Address")]

		[System.ComponentModel.DataAnnotations.Display
			(Name = "Confirm Email Address")]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessage = "{0} is required!")]

		[System.ComponentModel.DataAnnotations.Compare
			(otherProperty: "EmailAddress", ErrorMessage = "{0} is not equal to {1}!")]
		public string ConfirmEmailAddress { get; set; }
		// **********
	}
}
