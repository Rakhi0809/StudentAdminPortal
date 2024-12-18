namespace Studentadmin_Poratl.Models.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public required string Name { get; set; }    
        public required string Rollnum { get; set; }
        public required string Course { get; set; }
        public string? Fee { get; set; }




    }
}
