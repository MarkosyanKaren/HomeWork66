using HomeWork66.DAL.Entities;
using HomeWork66.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HomeWork66.DAL.Repositories;

public class PropertyRepo : IPropertyRepo
{
	private SchoolDBContext _dbContext;
    public PropertyRepo(SchoolDBContext schoolDBContext)
    {
        _dbContext = schoolDBContext;
    }


    public async Task<List<Property>> GetAllProperty()
	{
		var property = await _dbContext.Properties.ToListAsync();
		return property;
	}

	public Task CreateProperty(string name, int count)
	{
		var creatProperty = new Property()
		{
			Name = name,
			Count = count
		};

		_dbContext.Properties.Add(creatProperty);
		_dbContext.SaveChanges();

		return Task.CompletedTask;
	}

	public Task UpdateProperty(int Id, int count)
	{
		var updatedProperty = _dbContext.Properties.FirstOrDefault(x => x.Id == Id);
		updatedProperty.Count = count;

		_dbContext.Properties.Update(updatedProperty);
		_dbContext.SaveChanges();

		return Task.CompletedTask;
	}

	public Task DeleteProperty(int Id)
	{
		var deletedProperty = _dbContext.Properties.FirstOrDefault(x => x.Id == Id);

		_dbContext.Properties.Remove(deletedProperty);
		_dbContext.SaveChanges();

		return Task.CompletedTask;
	}
}
