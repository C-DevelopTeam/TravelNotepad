using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelApi.Models
{
    public class Diary
    {
        [Key]
        public int DiaryId{get; set;}
        public string Title{get; set;}
        public string Description{get; set;}
        public string Photo{get; set;}
        [Required]
        public int Share{get; set;}
        public int TravelId{get; set;}
        [ForeignKey("TravelId")]
        public Travel Travel{get; set;}
    }
}