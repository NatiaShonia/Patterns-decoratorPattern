using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class SocialMediaPost
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public  string Author { get; set; }
        public DateTime DatePosted { get; set; }
        public List<string> Tags { get; set; }
        public Uri ImageUri { get; set; }
        public List<Uri> Links { get; set; }



        public override string ToString()
        {
            var tagsString =  string.Join(", ", Tags);

            return Title + " " + Content + " " + Author + " " + DatePosted + " " + tagsString + " " + ImageUri + " " + Links;
        }

    }
}
