using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using BookStore.Models;

namespace BookStore.Pages.ProductDetails
{
    public class DeleteModel : PageModel
    {
        private readonly BookStore.Data.FinalContext _context;

        public DeleteModel(BookStore.Data.FinalContext context)
        {
            _context = context;
        }

        [BindProperty]
      public ProductDetail ProductDetail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ProductDetails == null)
            {
                return NotFound();
            }

            var productdetail = await _context.ProductDetails.FirstOrDefaultAsync(m => m.ID == id);

            if (productdetail == null)
            {
                return NotFound();
            }
            else 
            {
                ProductDetail = productdetail;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.ProductDetails == null)
            {
                return NotFound();
            }
            var productdetail = await _context.ProductDetails.FindAsync(id);

            if (productdetail != null)
            {
                ProductDetail = productdetail;
                _context.ProductDetails.Remove(ProductDetail);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
