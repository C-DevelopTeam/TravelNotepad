namespace TravelApi.Models
{
    class todo
    {
    [key]
    public int taskid{get;set;}

    public int state{get;set;}

    public string task{get;set;}
    
    [ForeignKey]
    public int routeid{get;set;}
    [ForeignKey]
    public string siteid{get;set;}
    }
}


