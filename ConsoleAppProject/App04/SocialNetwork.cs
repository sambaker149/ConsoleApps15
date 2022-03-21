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
                " Display Posts",
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
                        DisplayPosts();
                        break;
                    case 4:
                        wantToQuit = true;
                        break;
                }
            } while (!wantToQuit);
        }

        private void PostMessage()
        {
            ConsoleHelper.OutputHeading(" Add Message");

            Console.Write(" Please Enter the Author's Name > ");
            string author = Console.ReadLine();

            Console.Write(" Please Enter the Message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(message, author);
            feed.AddMessagePost(post);
        }

        public void PostPhoto()
        {
            ConsoleHelper.OutputHeading(" Add Photo");

            Console.Write(" Please Enter the Author's Name > ");
            string author = Console.ReadLine();

            Console.Write(" Please Choose the Photo > ");
            string photo = Console.ReadLine();

            Console.Write(" Please Add a Caption > ");
            string caption  = Console.ReadLine();

            PhotoPost post = new PhotoPost(caption, photo, author);
            feed.AddPhotoPost(post);
        }

        private void DisplayPosts()
        {
            feed.Display();
        }
    }
}