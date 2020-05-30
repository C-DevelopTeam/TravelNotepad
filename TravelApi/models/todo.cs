using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelApi.Models
{
    public class Todo
    {
        [Key]
        public int TaskId{get; set;}
        [Required]
        public int State{get; set;}
        [Required]
        public string Task{get; set;}
        public int RouteId{get; set;}
        [ForeignKey("RouteId")]
        public Route Route{get; set;}
        public string SiteId{get; set;}
        [ForeignKey("SiteId")]
        public Site Site{get; set;}
    }
}


