using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web.Data;

namespace Web.Pages.Network
{
    public class DetailsModel : PageModel
    {
        private readonly WebContext _context;

        public DetailsModel(WebContext context)
        {
            _context = context;
        }

        public MessagePost MessagePost { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MessagePost = await _context.Messages.FirstOrDefaultAsync(m => m.PostId == id);

            if (MessagePost == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}