using Newtonsoft.Json;
using System;


namespace AuthDemo.Model
{
    public class AuthTokenModel
    {
        [JsonProperty("uid")]
        public long UserId { get; set; }

        [JsonProperty("exp")]
        public DateTime Expirydate { get; set; }

        [JsonProperty("emailId")]
        public string EmailId { get; set; }

        [JsonProperty("sysIp")]
        public string SysIp { get; set; }

    }
}
