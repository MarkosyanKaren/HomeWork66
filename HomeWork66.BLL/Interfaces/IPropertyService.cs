using HomeWork66.DAL.Entities;

namespace HomeWork66.BLL.Interfaces;

public interface IPropertyService
{
	public Task<List<Property>> GetAllProperty();
	public Task CreateProperty(string name, int count);
	public Task UpdateProperty(int Id, int count);
	public Task DeleteProperty(int Id);
}
