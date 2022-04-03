using System;
using System.ComponentModel.DataAnnotations;
using Web.Pages.Network;

namespace Web.Pages.Network
{
    public class Comment
    {
        public int CommentId { get; set; }

        public int PostId { get; set; }

        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        public virtual Post Post { get; set; }
    }
}