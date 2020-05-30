using System.ComponentModel.DataAnnotations;

namespace TravelApi.Models
{
    public class User
    {
        [Key]
        public int Uid {get; set;}
        [Required]
        public string Uname {get; set;}
        [Required]
        public string Password {get; set;}
        public string Sex {get; set;}
        public string Introduction {get; set;}
    }
}