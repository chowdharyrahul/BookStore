namespace BookStore.Models
{
    public class Book
    {
       
            public int bookID { get; set; }
            public string bookName { get; set; }
            public string bookType { get; set; }
            public DateTime publishDate { get; set; }

            public string Publisher { get; set; }

            public string Language { get; set; }

            public string Paperback { get; set; }

            public long ISBN_10 { get; set; }

            public long ISBN_13 { get; set; }

            public string Item_Weight { get; set; }
            public string Dimensions { get; set; }
            public string BestSellersRank { get; set; }

            public float CustomerReview { get; set; }
            
            public List<Author> Authors { get; } = new();

            public ICollection<ProductDetail> ProductDetails { get; set; } = new List<ProductDetail>();

        }
    }

