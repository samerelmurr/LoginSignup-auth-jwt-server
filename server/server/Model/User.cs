/*using System;
using System.Collections.Generic;*/
using System.Text.Json.Serialization;

namespace server.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        [JsonIgnore]public string UserPassword { get; set; }
    }
}
