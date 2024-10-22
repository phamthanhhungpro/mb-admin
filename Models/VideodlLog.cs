namespace mbadmin.Models
{
    public class VideodlLog
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string Action { get; set; }
        public string Data { get; set; }  // This can be a string if storing JSON.
        public DateTime Time { get; set; }
    }
}
