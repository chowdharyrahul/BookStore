namespace BookStore.Models
{
    public class ProductDetail
    {
        public int ID { get; set; }
        public int bookID { get; set; }

        public string bookName { get; set; }

        public string authorName { get; set; }

        public int authorID { get; set; }

        public Book Book { get; set; }

        public Author Author { get; set; }

    }
}
