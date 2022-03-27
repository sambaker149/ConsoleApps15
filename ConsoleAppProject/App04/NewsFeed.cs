using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// The NewsFeed class stores news posts for the news feed 
    /// in a social network application
    /// </summary>
    /// <author>
    ///  Samuel Baker 27/03/2022
    /// </author> 
    public class NewsFeed
    {
        private readonly List<Post> posts;

        ///<summary>
        /// Construct a news feed containing sample posts
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();

            MessagePost messagePost = new MessagePost(" Sam", 
                " Hello World");
            AddMessagePost(messagePost);

            PhotoPost photoPost = new PhotoPost(" Sam", 
                "Image1.jpg", "Hello World");
            AddPhotoPost(photoPost);
        }

        ///<summary>
        /// Add a text post to the news feed
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        /// <summary>
        /// Find a post according to the ID assigned to each 
        /// post
        /// </summary>
        public Post FindPostByID(int id)
        {
            foreach (Post post in posts)
            {
                if (post.postID == id)
                {
                    return post;
                }
            }

            return null;
        }

        /// <summary>
        /// Find a post using a given ID and remove the selected post
        /// from the News Feed
        /// </summary>
        public void RemovePost(int id)
        {
            ConsoleHelper.OutputTitle(" Removing a Post");
            Post post = FindPostByID(id);

            if (post == null)
            {
                Console.WriteLine($" Post with ID {id} does not exist");
            }
            else
            {
                Console.WriteLine($" The Post with ID {id} has been removed");

                posts.Remove(post);
                post.Display();
            }
        }

        ///<summary>
        /// Shows the news feed details to the terminal
        ///</summary>
        public void Display()
        {
            ConsoleHelper.OutputTitle(" Displaying All Posts");

            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();
            }
        }

    }

}