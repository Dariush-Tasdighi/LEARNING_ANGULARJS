//namespace LEARNING_ANGULAR_JS.Models
namespace Models
{
	public abstract class BaseEntity : System.Object
	{
		public BaseEntity()
			: base()
		{
			// Note: Wrong Usage!
			//Id = new System.Guid();

			Id = System.Guid.NewGuid();
		}

		// **********
		public System.Guid Id { get; set; }
		// **********
	}
}
