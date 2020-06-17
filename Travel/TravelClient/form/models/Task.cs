namespace TravelClient.Models
{
    public class Task
    {
        public long TaskId{get; set;}
        public int State{get; set;}
        public string Description{get; set;}
        public long RouteId{get; set;}

        public Task() { }
    }
}


