using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using BookStore.Models;

namespace BookStore.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly BookStore.Data.FinalContext _context;

        public DetailsModel(BookStore.Data.FinalContext context)
        {
            _context = context;
        }

      public Author Author { get; set; }
        public Book Book { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Authors == null)
            {
                return NotFound();
            }


            var book = await _context.Books.FirstOrDefaultAsync(m => m.bookID == id);
            //var author = await _context.Authors.FirstOrDefaultAsync(m => m.authorID == id);
            var author = await _context.Authors
               .Include(b => b.ProductDetails)
               .ThenInclude(ba => ba.Book)
               .FirstOrDefaultAsync(m => m.authorID == id);
            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                Book = book;
            }
            return Page();
        }
    }
}
