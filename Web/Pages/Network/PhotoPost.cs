using System.ComponentModel.DataAnnotations;

namespace Web.Pages.Network
{
    /// <summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption
    /// </summary>
    /// <author>
    /// Samuel Baker 27/03/2022
    /// </author>
    public class PhotoPost : Post
    {
        [StringLength(128), Required]
        public String Filename { get; set; }

        [StringLength(150), Required]
        public String Caption { get; set; }
    }
}