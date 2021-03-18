using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopIP.Models.EmailModel
{
    public class EmailModel
    {
        public IFormFile EmailAttachment { get; set; }
        public string Email { get; set; }
        public string EmailBody { get; set; }
        public string Password { get; set; }
        public string EmailSubject { get; set; }
        public string EmailTo { get; set; }
        public string EmailContent { get; set; }
    }
}
