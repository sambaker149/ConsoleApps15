﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Pages.Network
{
    /// <summary>
    /// This class stores information about posts in a
    /// social network, including the Post ID, Author name,
    /// Timestamp, Likes and Comments
    /// </summary>
    /// <author>
    /// Samuel Baker 31/03/2022
    /// </author>
    [Serializable]
    public class Post
    {
        public int PostId { get; set; }

        [StringLength(20), Required]
        public string Author { get; set; }

        public DateTime Timestamp { get; set; }

        public int Likes { get; set; }

        //private readonly List<String> comments;

        /// <summary>
        /// Constructor for objects of class Post
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
        /// Record that a user has withdrawn their 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (Likes > 0)
            {
                Likes--;
            }
        }

        ///<summary>
        /// Create a string describing a time point in the past relative 
        /// to current time
        /// </summary>    
        public String FormatElapsedTime()
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - Timestamp;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;
            long hours = minutes / 60;
            long days = hours / 24;

            if (days > 0)
            {
                if (days == 1)
                {
                    return days + " day ago";
                }
                else if (days <= 7)
                {
                    return days + " days ago";
                }
                else
                {
                    return Timestamp.ToString("dd/MM/yyyy");
                }
            }
            else if (hours > 0)
            {
                return hours + " hours ago";
            }
            else if (minutes > 0)
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