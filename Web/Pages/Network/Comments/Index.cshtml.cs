using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Pages.Network;

namespace Web.Pages.Network.Comments
{
    public class IndexModel : PageModel
    {
        private readonly Web.Data.WebContext _context;

        public IndexModel(Web.Data.WebContext context)
        {
            _context = context;
        }

        public IList<Comment> Comment { get; set; }

        public async Task OnGetAsync()
        {
            Comment = await _context.Comments
                .Include(c => c.Post).ToListAsync();
        }
    }
}