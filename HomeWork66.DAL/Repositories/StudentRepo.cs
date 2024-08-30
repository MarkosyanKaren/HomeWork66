using HomeWork66.DAL.Entities;
using HomeWork66.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HomeWork66.DAL.Repositories;

public class StudentRepo : IStudentRepo
{
	private SchoolDBContext _dbContext;
    public StudentRepo(SchoolDBContext schoolDBContext)
    {
        _dbContext = schoolDBContext;
    }
    public async Task<List<Student>> GetAllStudent()
	{
		var student = await _dbContext.Students.ToListAsync();
		return student;
	}

	public Task CreateStudent(string name, string surname, string classNumber, string phoneNumber)
	{
		var creatStudent = new Student()
		{
			Name = name,
			Surname = surname,
			ClassNumber = classNumber,
			PhoneNumber = phoneNumber
		};

		_dbContext.Students.Add(creatStudent);
		_dbContext.SaveChanges();

		return Task.CompletedTask;
	}

	public Task UpdateStudent(int Id, string phoneNumber)
	{
		var updatedPhoneNumber = _dbContext.Students.FirstOrDefault(x => x.Id == Id);
		updatedPhoneNumber.PhoneNumber = phoneNumber;

		_dbContext.Students.Update(updatedPhoneNumber);
		_dbContext.SaveChanges();

		return Task.CompletedTask;
	}

	public Task DeleteStudent(int Id)
	{
		var deletedStudent = _dbContext.Students.FirstOrDefault(x => x.Id == Id);

		_dbContext.Students.Remove(deletedStudent);
		_dbContext.SaveChanges();

		return Task.CompletedTask;
	}
}
