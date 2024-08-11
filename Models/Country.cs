using System;
using System.ComponentModel.DataAnnotations;

namespace ALG.Models
{
	public class Country
	{
		[Key]
		public int Id { get; set; }
		public string CoutryName { get; set; }
		public List<City> Cities { get; set; }
	}
}

