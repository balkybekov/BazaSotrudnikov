using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaSotrudnikov.Domain.Models
{
    public class City
    {        
        public int Id { get; set; }
        [Required]
        [Display(Name = "Город")]
        [StringLength(150, ErrorMessage = "Длина поля должна быть до 150 символов")]
        public string Name { get; set; }

        public int? CountryId { get; set; }
        [Display(Name = "Страна")]
        public Country Country { get; set; }
    }
}
