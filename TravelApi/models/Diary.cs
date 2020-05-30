using System.ComponentModel.DataAnnotations;

namespace TravelApi.Models
{
    public class Diary
    {
        [Key]
        public int TravelId{get; set;}
        public string Title{get; set;}
        public string Description{get; set;}
        public string Photo{get; set;}
        [Required]
        public int Share{get; set;}
        [Required]
        public int IsDelete{get; set;}
    }
}