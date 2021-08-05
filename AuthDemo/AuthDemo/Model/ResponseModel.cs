using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthDemo.Model
{
    public class ResponseModel
    {
        public string Token { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
    }
}
