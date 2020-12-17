using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CPC2020_2_Lab4.Models.Entities
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
