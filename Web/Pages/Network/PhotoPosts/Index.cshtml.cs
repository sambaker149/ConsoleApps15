#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Pages.Network;

namespace Web.Pages.Network.PhotoPosts
{
    public class IndexModel : PageModel
    {
        private readonly Web.Data.WebContext _context;

        public IndexModel(Web.Data.WebContext context)
        {
            _context = context;
        }

        public IList<PhotoPost> PhotoPost { get;set; }

        public async Task OnGetAsync()
        {
            PhotoPost = await _context.Photos.ToListAsync();
        }
    }
}
