using HomeWork66.BLL.Interfaces;
using HomeWork66.DAL;
using HomeWork66.DAL.Entities;
using HomeWork66.DAL.Interfaces;
using HomeWork66.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork66.Controllers;

[ApiController]
[Route("api/")]
public class StudentController : Controller
{
	private SchoolDBContext _dbContext;
	private IStudentRepo _studentRepo;
	private IStudentService _studentService;
    public StudentController(SchoolDBContext schoolDBContext, IStudentRepo studentRepo, IStudentService studentService)
    {
        _dbContext = schoolDBContext;
        _studentRepo = studentRepo;
        _studentService = studentService;
    }

    [HttpGet("api/Student/GetStudent")]
    public Task<List<Student>> GetStudents()
    {
        return _studentService.GetAllStudent();
    }

    [HttpPost("api/Student/CreatStudent")]
    public Task CreatStudent(StudentCreateModel studentCreateModel)
    {
        return _studentService.CreateStudent(studentCreateModel.Name, studentCreateModel.Surname,
            studentCreateModel.ClassNumber, studentCreateModel.PhoneNumber);
    }

    [HttpPut("api/Student/UpdatePhoneNumber")]
    public Task UpdatePhoneNumber(StudentUpdateModel studentUpdateModel)
    {
        return _studentService.UpdateStudent(studentUpdateModel.Id, studentUpdateModel.PhoneNumber);
    }

    [HttpDelete("api/Atudent/DeleteStudent")]
    public Task DeleteStudent(int Id)
    {
        return _studentService.DeleteStudent(Id);
    }
}
