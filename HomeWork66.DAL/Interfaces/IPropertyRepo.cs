using HomeWork66.DAL.Entities;

namespace HomeWork66.DAL.Interfaces;

public interface IPropertyRepo
{
	public Task<List<Property>> GetAllProperty();
	public Task CreateProperty(string name, int count);
	public Task UpdateProperty(int Id, int count);
	public Task DeleteProperty(int Id);
}
