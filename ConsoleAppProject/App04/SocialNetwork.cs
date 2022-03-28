﻿using ConsoleAppProject.Helpers;
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
    /// <author>
    ///  Samuel Baker 27/03/2022
    /// </author> 
    public class SocialNetwork
    {
        private NewsFeed feed = new NewsFeed();
        public void Run()
        {
            OutputMenuChoices();
        }

        public void OutputMenuChoices()
        {
            ConsoleHelper.OutputHeading(" App04 - Social Network");
            string[] choices =
            {
                " Post Message",
                " Post Photo",
                " Remove Post",
                " Display All Posts",
                " Display Posts by Author",
                " Display Posts by Date",
                " Add Comment to Post",
                " Like or Unlike a Post",
                " Quit"
            };

            ExecuteChoice(choices);
        }

        private void ExecuteChoice(string[] choices)
        {
            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: 
                        PostMessage(); 
                        break;
                    case 2: 
                        PostPhoto(); 
                        break;
                    case 3: 
                        RemovePost(); 
                        break;
                    case 4: 
                        DisplayPosts(); 
                        break;
                    case 5: 
                        DisplayAuthorPosts(); 
                        break;
                    case 6: 
                        //DisplayByDate(); 
                        break;
                    case 7: 
                        AddComment(); 
                        break;
                    case 8: 
                        RatePost(); 
                        break;
                    case 9: 
                        wantToQuit = true; 
                        break;
                }
            } while (!wantToQuit);
        }

        /// <summary>
        /// Posts a Message post with the Author name and the
        /// message
        /// </summary>
        private void PostMessage()
        {
            ConsoleHelper.OutputHeading(" Add a Message");

            string author = InputName();

            Console.Write(" Please Enter the Message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(message, author);
            feed.AddMessagePost(post);

            Console.WriteLine(" You have successfully posted your Message");
            ConsoleHelper.OutputTitle(" Your Message:");
            post.Display();
        }

        /// <summary>
        /// Posts a photo post with the Author's name, the Image
        /// filename and the caption
        /// </summary>
        public void PostPhoto()
        {
            ConsoleHelper.OutputHeading(" Add a Photo");

            string author = InputName();

            Console.Write(" Please Enter the Image Filename > ");
            string photo = Console.ReadLine();

            Console.Write(" Please Add a Caption > ");
            string caption  = Console.ReadLine();

            PhotoPost post = new PhotoPost(caption, photo, author);
            feed.AddPhotoPost(post);

            Console.WriteLine(" You have successfully posted your Photo");
            ConsoleHelper.OutputTitle(" Your Photo:");
            post.Display();
        }

        /// <summary>
        /// Prompts the user to input the Author's name
        /// </summary>
        private string InputName()
        {
            Console.Write(" Please Enter the Author's Name > ");
            string author = Console.ReadLine();

            return author;
        }

        /// <summary>
        /// Removes the post from the News Feed based on the
        /// Post's ID
        /// </summary>
        private void RemovePost()
        {
            ConsoleHelper.OutputTitle(" Removing a Post");
            
            int id = (int)ConsoleHelper.InputNumber("Please Enter the Post ID > ");
            feed.RemovePost(id);
        }

        /// <summary>
        /// Displays all posts within the News Feed
        /// </summary>
        private void DisplayPosts()
        {
            ConsoleHelper.OutputTitle(" All Posts");
            
            feed.Display();
        }

        /// <summary>
        /// Allows the user to search for posts by a 
        /// certain Author
        /// </summary>
        private void DisplayAuthorPosts()
        {
            Console.WriteLine(" Please Enter the Author's Name > ");
            string author = Console.ReadLine();

            feed.DisplayByAuthor(author);
        }

        /// <summary>
        /// Allows the user to add a comment to a post
        /// </summary>
        private void AddComment()
        {
            int id = (int)ConsoleHelper.InputNumber(" Please Enter " +
                "the Post ID > ");

            feed.Comment(id);
            
        }

        /// <summary>
        /// Allows the user to add a Like or Unlike to a post
        /// </summary>
        private void RatePost()
        {
            int id = (int)ConsoleHelper.InputNumber(" Please Enter " +
                "the Post ID > ");

            feed.LikePost(id);
        }
    }
}