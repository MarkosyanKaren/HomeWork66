using HomeWork66.BLL.Interfaces;
using HomeWork66.DAL.Entities;
using HomeWork66.DAL.Interfaces;

namespace HomeWork66.BLL.Services;

public class PropertyService : IPropertyService
{
	private IPropertyRepo _propertyRepo;
    public PropertyService(IPropertyRepo propertyRepo)
    {
        _propertyRepo = propertyRepo;
    }


    public async Task<List<Property>> GetAllProperty()
	{
		var property = await _propertyRepo.GetAllProperty();
		return property;
	}

	public Task CreateProperty(string name, int count)
	{
		if(count < 0)
		{
            Console.WriteLine("Error");
			return Task.CompletedTask;
		}
		else
		{
			return _propertyRepo.CreateProperty(name, count);
		}
	}

	public Task UpdateProperty(int Id, int count)
	{
		if (Id == 1)
		{
			Console.WriteLine("Error");
			return Task.CompletedTask;
		}
		else
		{
			return _propertyRepo.UpdateProperty(Id, count);
		}
	}

	public Task DeleteProperty(int Id)
	{
		if (Id == 1)
		{
			Console.WriteLine("Error");
			return Task.CompletedTask;
		}
		else
		{
			return _propertyRepo.DeleteProperty(Id);
		}
	}

}
