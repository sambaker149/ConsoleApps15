using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Pages.Network
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a PostId. Other data, such 
    /// as author, time, likes, and comments are also stored.
    /// </summary>
    /// <author>
    /// Samuel Baker 03/04/2022
    /// </author>
    [Serializable]
    public class Post
    {
        public int PostId { get; set; }

        [StringLength(20), Required]
        public String Author { get; set; }

        public DateTime Timestamp { get; set; }

        public int Likes { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public Post()
        {
            Timestamp = DateTime.Now;
            Likes = 0;
        }

        /// <summary>
        /// Record one more 'Like' indication from a user.
        /// </summary>
        public void Like()
        {
            Likes++;
        }

        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (Likes > 0)
            {
                Likes--;
            }
        }


        ///<summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>    
        public String FormatElapsedTime()
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - Timestamp;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
    }
}