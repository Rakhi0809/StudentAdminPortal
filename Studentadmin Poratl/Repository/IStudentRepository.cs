using Microsoft.AspNetCore.Mvc;
using Studentadmin_Poratl.Models.Entities;

namespace Studentadmin_Poratl.Repository
{
    public interface IStudentRepository
    {
        Task<Student> GetAllStudents();
    }
}
