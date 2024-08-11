using System;
using System.ComponentModel.DataAnnotations;

namespace ALG.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		public string ProductName { get; set; }
		public DateTime Date { get; set; }
		public Client Client { get; set; } // навигационное свойство
		public int ProductSoldCount { get; set; }

	}
}

