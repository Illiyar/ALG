using System;
using System.ComponentModel.DataAnnotations;

namespace ALG.Models
{
	public class City
	{
		[Key]
		public int Id { get; set; }
		[Display(Name = "Страна")]
		[Required]
		public Country Country { get; set; }
        [Display(Name = "Город")]
        [Required]
        public string CityName { get; set; }
        [Display(Name = "Количество жителей")]
        [Required]
        public int PeopleCount { get; set; }
	}
}

