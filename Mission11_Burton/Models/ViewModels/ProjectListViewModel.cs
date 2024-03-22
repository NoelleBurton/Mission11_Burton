namespace Mission11_Burton.Models.ViewModels
{
    public class ProjectListViewModel
    {
        public IQueryable<Project> Projects { get; set;}
        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();

    }
}
