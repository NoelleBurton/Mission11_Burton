namespace Mission11_Burton.Models.ViewModels
{
    public class ProjectListViewModel
    {
        public IQueryable<Books> Books { get; set;}
        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();

    }
}
