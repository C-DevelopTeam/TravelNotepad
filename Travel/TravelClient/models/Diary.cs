using System;

namespace TravelClient.Models
{
    public class Diary
    {
        public long DiaryId{get; set;}
        public DateTime Time{get; set;}
        public string Title{get; set;}
        public string Description{get; set;}
        public string Photo{get; set;}
        public int Share{get; set;}
        public int Uid { get; set; }
        public long? TravelId{get; set;}

        public Diary() { }
    }
}