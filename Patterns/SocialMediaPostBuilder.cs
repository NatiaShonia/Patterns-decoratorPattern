using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class SocialMediaPostBuilder
    {
        private readonly SocialMediaPost Post = new SocialMediaPost();

        //public SocialMediaPost Post = new SocialMediaPost();


        public SocialMediaPostBuilder AddTitle(string title)
        {
            Post.Title= title;
            return this;
        }

        public SocialMediaPostBuilder AddContent(string content)
        {
            Post.Content=content;
            return this;

        }

        public SocialMediaPostBuilder AddAuthor(string author)
        { 
            Post.Author= author;
            return this;
        }

        public SocialMediaPostBuilder  SetPostDate(DateTime datePosted)
        {
           Post.DatePosted= datePosted;
            return this;
        }

        public SocialMediaPostBuilder AddTag(string tag)
        {
            if (Post.Tags == null)
            {
                Post.Tags= new List<string>();
            }
            //Post.Tags = tag;
            Post.Tags.Add(tag);
            return this;
        }

        public SocialMediaPostBuilder AddImage(Uri imageUri)
        {
            Post.ImageUri= imageUri;
            return this;
        }

        public SocialMediaPostBuilder AddLink(Uri link)
        {
            if (Post.Links == null)
            {
                Post.Links = new List<Uri>();
            }
            Post.Links.Add(link);
            return this;
        }



        public SocialMediaPost Builder()
        {
            return Post;
        }

        


    }
}
