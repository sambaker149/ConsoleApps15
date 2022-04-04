using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Web.Pages.Network
{
    public class IndexModel : PageModel
    {

        private readonly Data.WebContext _context;

        public IndexModel(Data.WebContext context) => _context = context;

        public IList<MessagePost> MessagePost { get; set; }
        public IList<Comment> Comment { get; set; }
        public string currentSearch { get; set; }

        public async Task OnGetAsync(string userName)
        {

            MessagePost = await _context.Messages.OrderByDescending(a => a.Timestamp).ToListAsync();
            Comment = await _context.Comments
                .Include(c => c.Post).ToListAsync();

            currentSearch = userName;

            IQueryable<MessagePost> messagesIQ = from p in _context.Messages
                                                 select p;
            if (!String.IsNullOrEmpty(userName))
            {
                messagesIQ = messagesIQ.Where(p => p.Author.Contains(userName));
            }

            MessagePost = await messagesIQ.AsNoTracking().ToListAsync();
        }

        public ActionResult OnGetLike(int id)
        {
            var messagePost = _context.Messages.Find(id);

            if (messagePost == null)
            {
                return NotFound();
            }
            else
            {
                messagePost.Like();
            }

            try
            {
                _context.Update(messagePost);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return Redirect(Url.Action("Index") + $"#{id}");
        }

        public ActionResult OnGetUnLike(int id)
        {
            var messagePost = _context.Messages.Find(id);

            if (messagePost == null)
            {
                return NotFound();
            }
            else
            {
                messagePost.Unlike();
            }

            try
            {
                _context.Update(messagePost);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return Redirect(Url.Action("Index") + $"#{id}");
        }

        [BindProperty]
        public string Text { get; set; }

        public async Task<IActionResult> OnPost(int id)
        {
            Comment comment = new Comment();
            comment.Text = Text;
            comment.PostId = id;

            _context.Add(comment);
            await _context.SaveChangesAsync();

            return Redirect(Url.Action("Index") + $"#{id}");
        }
    }
}