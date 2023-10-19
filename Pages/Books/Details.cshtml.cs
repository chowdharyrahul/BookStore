using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using BookStore.Models;

namespace BookStore.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly BookStore.Data.FinalContext _context;

        public DetailsModel(BookStore.Data.FinalContext context)
        {
            _context = context;
        }

      public Book Book { get; set; }
        public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            var book = await _context.Books
               .Include(b => b.ProductDetails)
               .ThenInclude(ba => ba.Author)
               .FirstOrDefaultAsync(m => m.bookID == id);
            var author = await _context.Authors.FirstOrDefaultAsync(m => m.authorID == id);

            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            if (author == null)
            {
                return NotFound();
            }
            else
            {
                Author = author;
            }
            return Page();
        }
    }
}
