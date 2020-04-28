using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Уведіть від 2 до 50 символів")]
        public string Name { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
        public virtual ICollection<Band> Bands { get; set; }
    }
}
