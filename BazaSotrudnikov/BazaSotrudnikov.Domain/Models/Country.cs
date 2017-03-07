using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaSotrudnikov.Domain.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Страна")]
        [StringLength(150, ErrorMessage = "Длина поля должна быть до 150 символов")]
        public string Name { get; set; }

        [Display(Name = "Города страны")]
        public ICollection<City> Cities { get; set; }
        public Country()
        {
            Cities = new List<City>();
        }
    }
}
