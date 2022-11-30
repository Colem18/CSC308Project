using System;
namespace eventsApp.Data
{
    public class Account
    {
        public string id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public bool is_admin { get; set; }
        public string[] following_list { get; set; }
    }
}