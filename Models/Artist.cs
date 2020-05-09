using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SavinaMusicLab.Models
{

    public partial class Artist
    {
        public int Id { get; set; }
        [Display(Name = "Ім'я виконавця")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Довжина імені від 2 до 50 символів")]
        
        public string Name { get; set; }
        [Display(Name = "Дата народження")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [RegularExpression(@"^(([0][1-9])|([1-2][0-9])|([3][0-1]))\.(([0][1-9])|([1-2][0-9])|([3][0-1]))\.(([1][8-9][0-9][0-9])|([2][0][0-1][0-5]))$", ErrorMessage = "Введіть дату правильно у форматі DD.MM.YYYY, рік народження має бути не більше ніж 2004")]
        public string DateofBirth { get; set; }
        [Display(Name = "Дата смерті")]
        [RegularExpression(@"^(([0][1-9])|([1-2][0-9])|([3][0-1]))\.(([0][1-9])|([1][0-2]))\.(([1][8-9][0-9][0-9])|([2][0][0-1][0-9]))|((([0][1-9])|([1-2][0-9])|([3][0-1]))\.(([0][1-4])\.[2][0][2][0]))|((([0][1-9])|([1][0-9]))\.(([0][5])\.[2][0][2][0]))$", ErrorMessage = "Введіть дату правильно у форматі DD.MM.YYYY")]
        public string DateofDeath { get; set; }
        public int BandId { get; set; }
        public int CountryId { get; set; }
        [Display(Name = "Країна")]
        [JsonIgnore]
        public virtual Country Country { get; set; }
        [Display(Name = "Група")]
        [JsonIgnore]
        public virtual Band Band { get; set; }
    }
}
