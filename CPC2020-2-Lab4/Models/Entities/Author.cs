using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CPC2020_2_Lab4.Models.Entities
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
