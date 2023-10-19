using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookStore.Data;
using BookStore.Models;

namespace BookStore.Pages.ProductDetails
{
    public class CreateModel : PageModel
    {
        private readonly BookStore.Data.FinalContext _context;

        public CreateModel(BookStore.Data.FinalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["authorID"] = new SelectList(_context.Authors, "authorID", "authorID");
        ViewData["bookID"] = new SelectList(_context.Books, "bookID", "bookID");
            return Page();
        }

        [BindProperty]
        public ProductDetail ProductDetail { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProductDetails.Add(ProductDetail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
