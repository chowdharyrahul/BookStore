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
    public class DetailsModel : PageModel
    {
        private readonly BookStore.Data.FinalContext _context;

        public DetailsModel(BookStore.Data.FinalContext context)
        {
            _context = context;
        }

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
    }
}
