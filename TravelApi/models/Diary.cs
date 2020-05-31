using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace TravelApi.Models
{
    public class Diary
    {
        [Key]
        public long DiaryId{get; set;}
        [Required]
        public DateTime Time{get; set;}
        public string Title{get; set;}
        public string Description{get; set;}
        public string Photo{get; set;}
        [Required]
        public int Share{get; set;}
        public long? TravelId{get; set;}
        [ForeignKey("TravelId")]
        public Travel Travel{get; set;}
    }
}