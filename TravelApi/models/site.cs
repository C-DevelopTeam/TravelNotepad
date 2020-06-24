using System.ComponentModel.DataAnnotations;


namespace TravelApi.Models
{
    public class Site
    {
        [Key]
        public string SiteId{get; set;}
        [Required]
        public string SiteName{get; set;}
        [Required]
        public string City{get; set;}
        public string Distinct{get; set;}
        public string Adcode{get; set;}
        public string Location{get; set;}
        public string Address{get; set;}
    }
}