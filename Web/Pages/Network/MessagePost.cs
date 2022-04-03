using System;
using System.ComponentModel.DataAnnotations;

namespace Web.Pages.Network
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Samuel Baker 03/04/2022
    /// </author>
    public class MessagePost : Post
    {
        [StringLength(256), DataType(DataType.MultilineText)]
        public String Message { get; set; }
    }
}