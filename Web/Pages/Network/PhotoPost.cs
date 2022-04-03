using System;
using System.ComponentModel.DataAnnotations;

namespace Web.Pages.Network
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Samuel Baker 03/04/2022
    /// </author>
    public class PhotoPost : Post
    {
        [StringLength(128), Required]
        public String Filename { get; set; }

        [StringLength(30), Required]
        public String Caption { get; set; }
    }
}