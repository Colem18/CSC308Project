using System;
namespace eventsApp.Data
{
    public class Event
    {
        public string id { get; set; }
        public string name { get; set; }
        public string datetime { get; set; }
        public string address { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public int type { get; set; }
    }
}