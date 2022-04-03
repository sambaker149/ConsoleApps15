using ConsoleAppProject.App04;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Pages.Network
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a comment. Other data, 
    /// such as author, are also stored.
    /// </summary>
    /// <author>
    /// Samuel Baker 03/04/2022
    /// </author>
    public class Comment
    {
        public int CommentId { get; set; }

        public int PostId { get; set; }

        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        public virtual Post Post { get; set; }
    }
}