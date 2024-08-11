using System;
using System.ComponentModel.DataAnnotations;

namespace ALG.Models
{
	public class Client
	{
		[Key]
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string NumberPhone { get; set; }
		public string Address { get; set; }

		public List<Product> Products { get; set; } //связь один ко многим

	}
}

