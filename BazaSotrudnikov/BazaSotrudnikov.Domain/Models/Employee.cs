using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaSotrudnikov.Domain.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Введите фамилию")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Длина поля должна быть от 3 до 150 символов")]
        public string Surname { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Введите имя")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Длина поля должна быть от 3 до 150 символов")]
        public string Name { get; set; }

        [Display(Name = "Отчество")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Длина поля должна быть от 3 до 150 символов")]
        public string Father { get; set; }

        [Display(Name = "Телефон")]
        [StringLength(10, ErrorMessage = "Длина поля должна быть до 10 символов")]
        [RegularExpression(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$",
            ErrorMessage = "Не корректный номер телефона")]
        public string Phone { get; set; }

        [Display(Name = "Электронная почта")]
        [StringLength(50, ErrorMessage = "Длина поля должна быть до 50 символов")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        public int? CountryId { get; set; }
        [Display(Name = "Страна")]
        public Country Country { get; set; }

        public int? CityId { get; set; }
        [Display(Name = "Город")]
        public City City { get; set; }
    }
}
