using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelApi.Models
{
    public class UserTravel
    {
        [Key]
        public int Uid{get; set;}
        [ForeignKey("Uid")]
        public User User{get; set;}
        [Key]
        public int TravelId{get; set;}
        [ForeignKey("TravelId")]
        public Diary Diary{get; set;}
    }
}