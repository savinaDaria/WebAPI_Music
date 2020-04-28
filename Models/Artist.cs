using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
        public string DateofBirth { get; set; }
        [Display(Name = "Дата смерті")]
        public string DateofDeath { get; set; }
        public int BandId { get; set; }
        public int CountryId { get; set; }
        [Display(Name = "Країна")]
        public virtual Country Country { get; set; }
        [Display(Name = "Група")]
        public virtual Band Band { get; set; }
    }
}
