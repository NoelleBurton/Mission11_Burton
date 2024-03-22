using System.ComponentModel.DataAnnotations;

namespace Mission11_Burton.Models
{
    public class Project
    {
        [Key]
        public int ProjectId {  get; set; }
        public required string ProjectName { get; set; }
        public required string ProgramName { get; set; }
        public required string ProjectType { get; set; }
        public required string ProjectImpact { get; set; }
        public DateTime ProjectInstallation {  get; set; }

        public string ProjectPhase { get; set; }

    }
}
