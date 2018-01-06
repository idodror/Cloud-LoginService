using System;

namespace LoginService.Models {
    public class Data {
        public string userID { get; set; }
        public string tokenID { get; set; }
        public int ttl { get; set; }
        public DateTime create { get; set; }

    }
}