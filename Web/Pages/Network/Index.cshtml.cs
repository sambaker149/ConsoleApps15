using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Web.Pages.Network
{
    public class IndexModel : PageModel
    {

        private readonly Data.WebContext _context;

        public IndexModel(Data.WebContext context)
        {
            _context = context;
        }

        public IList<MessagePost> MessagePost { get; set; }

        public async Task OnGetAsync()
        {
            MessagePost = await _context.Messages.ToListAsync();
        }
    }
}