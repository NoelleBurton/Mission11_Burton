namespace Mission11_Burton.Models
{
    public interface IBookstoreRepository
    {
        public IQueryable<Books> Books { get; }
    }
}
