namespace LocationApi.Models
{
    public class Location
    {
        public int Id { get; set; }
        
        public string LocationName { get; set; } 

        public string Address { get; set; }
        public string Coordinates { get; set; }
        public string Url { get; set; }
    }
}
