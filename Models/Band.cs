using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SavinaMusicLab.Models
{
    public class Band
    {
        public Band()
        {
            Artists = new List<Artist>();
            Albums = new List<Album>();
        }

        public int Id { get; set; }
        [Display(Name = "Назва групи")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Довжина назви групи від 2 до 50 символів")]
        public string Name { get; set; }
        [Display(Name = "Рік створення")]
        [Range(1800, 2020, ErrorMessage = "Уведіть рік від 1800 до поточного")]
        public int? Year { get; set; }
        public int CountryId { get; set; }
        [Display(Name = "Країна")]
        [JsonIgnore]
        public virtual Country Country { get; set; }
        [JsonIgnore]
        public virtual ICollection<Artist> Artists { get; set; }
        [JsonIgnore]
        public virtual ICollection<Album> Albums { get; set; }
    }
}
