using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelApi.Models
{
    public class Task
    {
        [Key]
        public long TaskId{get; set;}
        [Required]
        public int State{get; set;}
        [Required]
        public string Description{get; set;}
        public long RouteId{get; set;}
        [ForeignKey("RouteId")]
        public Route Route{get; set;}
    }
}


