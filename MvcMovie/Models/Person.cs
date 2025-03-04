using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public required string PersonID { get; set; }
        public required string Fullname { get; set; }
        public string? Address { get; set; }
    }
}