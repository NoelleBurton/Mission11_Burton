namespace Mission11_Burton.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private Bookstore _context;
        public EFBookstoreRepository(Bookstore temp) 
        {
            _context = temp;
        }
        public IQueryable<Books> Books => _context.Books;

    }
}
