using System;

namespace TravelClient.Models
{
    public class Route
    {
        public long RouteId{get; set;}
        public int State{get; set;}
        public string Method{get; set;}
        public DateTime StartTime {get; set;}
        public DateTime EndTime {get; set;}
        public string StartSiteId{get; set;}
        public string EndSiteId{get; set;}
        public long TravelId{get; set;}

        public Route() { }
    }
}