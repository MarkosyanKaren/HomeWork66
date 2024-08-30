using HomeWork66.DAL.Entities;

namespace HomeWork66.DAL.Interfaces;

public interface IStudentRepo
{
	public Task<List<Student>> GetAllStudent();
	public Task CreateStudent(string name, string surname, string classNumber, string phoneNumber);
	public Task UpdateStudent(int Id, string phoneNumber);
	public Task DeleteStudent(int Id);
}
