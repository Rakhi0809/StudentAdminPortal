namespace Studentadmin_Poratl.Models
{
    public class AddStudentDto
    {
        public required string Name { get; set; }
        public required string Rollnum { get; set; }
        public required string Course { get; set; }
        public string? Fee { get; set; }
    }
}
