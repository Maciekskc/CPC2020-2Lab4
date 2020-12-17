using System.ComponentModel.DataAnnotations;

namespace CPC2020_2_Lab4.Models.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
