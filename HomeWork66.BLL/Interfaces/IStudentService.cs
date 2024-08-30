using HomeWork66.DAL.Entities;

namespace HomeWork66.BLL.Interfaces;

public interface IStudentService
{
	public Task<List<Student>> GetAllStudent();
	public Task CreateStudent(string name, string surname, string classNumber, string phoneNumber);
	public Task UpdateStudent(int Id, string phoneNumber);
	public Task DeleteStudent(int Id);
}
