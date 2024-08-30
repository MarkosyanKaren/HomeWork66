using HomeWork66.BLL.Interfaces;
using HomeWork66.DAL.Entities;
using HomeWork66.DAL.Interfaces;

namespace HomeWork66.BLL.Services;

public class StudentService : IStudentService
{
	private IStudentRepo _studentRepo;
    public StudentService(IStudentRepo studentRepo)
    {
        _studentRepo = studentRepo;
    }
    public async Task<List<Student>> GetAllStudent()
	{
		var student = await _studentRepo.GetAllStudent();
		return student;
	}

	public Task CreateStudent(string name, string surname, string classNumber, string phoneNumber)
	{
		if (name == "Hamo")
		{
            Console.WriteLine("Error");
			return Task.CompletedTask;
		}
		else
		{
			return _studentRepo.CreateStudent(name, surname, classNumber, phoneNumber);
		}
	}

	public Task UpdateStudent(int Id, string phoneNumber)
	{
		if (Id == 1)
		{
			Console.WriteLine("Error");
			return Task.CompletedTask;
		}
		else
		{
			return _studentRepo.UpdateStudent(Id, phoneNumber);
		}
	}

	public Task DeleteStudent(int Id)
	{
		if(Id == 1)
		{
			Console.WriteLine("Error");
			return Task.CompletedTask;
		}
		else
		{
			return _studentRepo.DeleteStudent(Id);
		}
	}
}
