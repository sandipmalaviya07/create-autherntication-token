using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthDemo.Model
{
    public class LoginReq
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Md5Password { get; set; }
    }
}
