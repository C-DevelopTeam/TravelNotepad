using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TravelApi.Models
{
    public class Route
    {
        [Key]
        public int RouteId{get; set;}
        [Required]
        public int State{get; set;}
        [Required]
        public string Method{get; set;}
        public DateTime StartTime {get; set;}
        public DateTime EndTime {get; set;}
        public string StartSiteId{get; set;}
        [ForeignKey("StartSiteId")]
        public Site StartSite{get; set;}
        public string EndSiteId{get; set;}
        [ForeignKey("EndSiteId")]
        public Site EndSite{get; set;}
        public int TravelId{get; set;}
        [ForeignKey("TravelId")]
        public Travel Travel{get; set;}

        public List<Task> Tasks{get; set;}
    }
}