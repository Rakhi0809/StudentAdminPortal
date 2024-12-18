namespace Studentadmin_Poratl.Models
{
    public class UpdateStudentDto
    {
        public required string Name { get; set; }
        public required string Rollnum { get; set; }
        public required string Course { get; set; }
        public string? Fee { get; set; }
    }
}
