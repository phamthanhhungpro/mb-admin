using Newtonsoft.Json;

namespace mbadmin.Models
{
    public class MailLog
    {
        public int Id { get; set; }
        public string FromIp { get; set; }
        public string TypeOfAction { get; set; }
        public string Action { get; set; }
        public string Value { get; set; }  // This can be a string if storing JSON.
        public DateTime Time { get; set; }
    }
}
