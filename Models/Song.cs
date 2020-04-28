using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SavinaMusicLab.Models
{
    public class Song
    {
        public Song()
        {
            SongGenres = new List<SongGenre>();
        }
        public int Id { get; set; }
        [Display(Name = "Пісня")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Уведіть від 2 до 50 символів")]
        public string Name { get; set; }
        public int AlbumId { get; set; }
        [Display(Name = "Альбом")]
        public virtual Album Album { get; set; }
        public virtual ICollection<SongGenre> SongGenres{ get; set; }
    }
}
