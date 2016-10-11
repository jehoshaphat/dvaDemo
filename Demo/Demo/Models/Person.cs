using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
	public class Person
	{
		[Required]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Required]
		[StringLength(50)]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Required]
		[Range(16, 150, ErrorMessage = "Age must be between 16 and 150 years old")]
		[Display(Name = "Age in years")]
		public int Age { get; set; }

		[Required]
		[DataType(DataType.PhoneNumber)]
		[Phone]
		[Display(Name = "Phone Number")]
		public string PhoneNumber { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		[EmailAddress]
		[Display(Name = "Email Address")]
		public string Email { get; set; }

		[Required]
		[StringLength(255)]
		[Display(Name = "Address One")]
		public string AddressOne { get; set; }

		[StringLength(255)]
		[Display(Name = "Address Two")]
		public string AddressTwo { get; set; }

		[Required]
		[StringLength(40)]
		public string City { get; set; }

		[Required]
		[StringLength(80)]
		public string State { get; set; }

		[Required]
		[StringLength(40)]
		public string Zip { get; set; }

		[Required]
		[StringLength(80)]
		public string Country { get; set; }
	}
}