using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_application_project
{
    public class Mail
    {
        public string title { get; set; }
        public string sender { get; set; }
        public string content { get; set; }

        public Mail(string title, string sender ,string content)
        {
            this.title = title;
            this.sender = sender;
            this.content = content;
        }
    }
}
