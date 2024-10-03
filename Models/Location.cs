namespace LocationApi.Models
{
    public class Location
    {
        public int Id { get; set; }
        
        public string LocationName { get; set; } 

        public string Address { get; set; }
        
        public double Latitude { get; set; }
        
        public double Longitude { get; set; }

        public string Url { get; set; }
    }
}
