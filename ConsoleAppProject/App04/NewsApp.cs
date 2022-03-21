using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// This app will allow the user to add message and photo posts to
    /// a list of posts
    /// Users can also display the posts in a variety of ways
    /// </summary>
    public class NewsApp
    {
        public NewsFeed NewsFeed { get; set; }
        public string[] Choices = 
        {
            " Add Message Post",
            " Add Photo Post",
            " Display All Posts"
        };

        public NewsApp()
        {
            NewsFeed = new NewsFeed();       
        }
        public void Run()
        {
            AddMessagePost();
        }

        private void AddMessagePost()
        {
            ConsoleHelper.OutputHeading(" Add Message");

            Console.Write(" Please Enter the Author's Name > ");
            string author = Console.ReadLine();

            Console.Write(" Please Enter the Message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(message, author);
            NewsFeed.Posts.Add(post);
        }
    }
}
