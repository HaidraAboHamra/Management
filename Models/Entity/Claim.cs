using System.ComponentModel.DataAnnotations;

namespace Test1.Models.Entity
{
    public class Claim
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public User? User { get; set; }
    }
}
