using System;

namespace LoginService.Models {
    public class User {
        public string _id { get; set; }
        public string _rev { get; set; }
        public string password { get; set; }
    }
    public class UserNoRev {
        public string _id { get; set; }
        public string password { get; set; }

        public UserNoRev(User u) {
            this._id = "id:" + u._id;
            this.password = u.password;
        }
    }

    public class Token {
        public string _id { get; set; }
        public int ttl { get; set; }
        public DateTime create { get; set; }

        public Token() {}


    }
}