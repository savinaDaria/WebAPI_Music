using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SavinaMusicLab.Models
{
    public class Country
    {
        public Country()
        {
            Artists = new List<Artist>();
            Bands = new List<Band>();
        }

        public int Id { get; set; }
        [Display(Name = "Країна")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [RegularExpression(@"^([a-zA-Z\' ']{2,})|([а-яіїєщА-ЯІЇЄЩ\' ']{2,})$", ErrorMessage = "Введіть назву правильно")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Уведіть від 2 до 50 символів")]
        public string Name { get; set; }
        [JsonIgnore]
        public virtual ICollection<Artist> Artists { get; set; }
        [JsonIgnore]
        public virtual ICollection<Band> Bands { get; set; }
    }
}
