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
    public class IndexModel : PageModel
    {
        private readonly BookStore.Data.FinalContext _context;

        public IndexModel(BookStore.Data.FinalContext context)
        {
            _context = context;
        }

        public IList<ProductDetail> ProductDetail { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ProductDetails != null)
            {
                ProductDetail = await _context.ProductDetails
                .Include(p => p.Author)
                .Include(p => p.Book).ToListAsync();
            }
        }
    }
}
