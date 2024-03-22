namespace Mission11_Burton.Models
{
    public interface IWaterRepository
    {
        public IQueryable<Project> Projects { get; }
    }
}
