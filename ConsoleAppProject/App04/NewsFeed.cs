using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Samuel Baker 22/03/2022
    ///</author> 
    public class NewsFeed
    {
        private readonly List<Post> posts;

        ///<summary>
        /// Construct an empty news feed.
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
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        /// <summary>
        /// 
        /// </summary>
        public Post FindPost(int id)
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
        /// 
        /// </summary>
        public void RemovePost(int id)
        {
            Post post = FindPost(id);

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
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
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
