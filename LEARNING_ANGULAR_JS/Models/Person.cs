//namespace LEARNING_ANGULAR_JS.Models
namespace Models
{
	public class Person : BaseEntity
	{
		public Person() : base()
		{
		}

		// **********
		public int Age { get; set; }
		// **********

		// **********
		public bool IsActive { get; set; }
		// **********

		// **********
		public string LastName { get; set; }
		// **********

		// **********
		public string FirstName { get; set; }
		// **********
	}
}
