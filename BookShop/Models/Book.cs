using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Titel { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Erscheinungsdatum { get; set; }
        [Required]
        public  string Autor { get; set; }
        [Required]
        public int Page { get; set; }
        [Required]
        public string Language { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
    }
}
