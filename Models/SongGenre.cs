using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SavinaMusicLab.Models
{
    public class SongGenre
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public int GenreId { get; set; }
        [Display(Name = "Пісня")]
        [JsonIgnore]
        public virtual Song Song { get; set; }
        [Display(Name = "Жанр")]
        [JsonIgnore]
        public virtual Genre Genre { get; set; }
    }
}
