using System;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SocialMediaPost post = new SocialMediaPostBuilder()
                                              .AddTitle("Satauri------- Builder Pattern  ")
                                              .AddContent("Shinaarsi---Builderis agwera")
                                              .AddAuthor("avtori-----levan doliashvili")
                                              .AddTag("#design pattern")
                                              .AddTag("#csharp")
                                              .AddLink(new Uri ("https://somelink.io"))

                                             .Builder();



            Console.WriteLine(post.ToString());
        }
    }
}
