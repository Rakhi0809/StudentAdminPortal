using Microsoft.AspNetCore.Mvc;
using Studentadmin_Poratl.Data;
using Studentadmin_Poratl.Models.Entities;

namespace Studentadmin_Poratl.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public StudentRepository(ApplicationDbcontext Dbcontext)
        {
                
        }
        public async Task<Student> GetAllStudents()
        {
            await Dbcontext.
        }
    }
}
