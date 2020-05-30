using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TravelApi.Models
{
    public class Travel
    {
        [Key]
        public int TravelId {get; set;}
        public string Description {get; set;}
        public int Uid {get; set;}
        [ForeignKey("Uid")]
        public User User {get; set;}

        public List<Route> Routes{get; set;}
    }
}