namespace BookStore.Models
{
    public class Author
    {
        public int authorID { get; set; }
        public string authorName { get; set; }

        public string About { get; set; }
        public List<Book> Books { get; } = new();
        public ICollection<ProductDetail> ProductDetails { get; set; } = new List<ProductDetail>();
    }
}
