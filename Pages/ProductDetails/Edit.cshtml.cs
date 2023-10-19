using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using BookStore.Models;

namespace BookStore.Pages.ProductDetails
{
    public class EditModel : PageModel
    {
        private readonly BookStore.Data.FinalContext _context;

        public EditModel(BookStore.Data.FinalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProductDetail ProductDetail { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ProductDetails == null)
            {
                return NotFound();
            }

            var productdetail =  await _context.ProductDetails.FirstOrDefaultAsync(m => m.ID == id);
            if (productdetail == null)
            {
                return NotFound();
            }
            ProductDetail = productdetail;
           ViewData["authorID"] = new SelectList(_context.Authors, "authorID", "authorID");
           ViewData["bookID"] = new SelectList(_context.Books, "bookID", "bookID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ProductDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductDetailExists(ProductDetail.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProductDetailExists(int id)
        {
          return _context.ProductDetails.Any(e => e.ID == id);
        }
    }
}
