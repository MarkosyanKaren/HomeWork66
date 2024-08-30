using HomeWork66.BLL.Interfaces;
using HomeWork66.DAL.Entities;
using HomeWork66.DAL.Interfaces;

namespace HomeWork66.BLL.Services;

public class StaffService : IStaffService
{
	private IStaffRepo _staffRepo;
    public StaffService(IStaffRepo staffRepo)
    {
        _staffRepo = staffRepo;
    }

    public  async Task<List<Staff>> GetAllStaff()
	{
		var staff = await _staffRepo.GetAllStaff();
		return staff;
	}

	public Task CreateStaff(string name, string surname, string position, string phoneNumber)
	{
		if (name == "Gago")
		{
            Console.WriteLine("Error");
			return Task.CompletedTask;	
		}
		else
		{
			return _staffRepo.CreateStaff(name, surname, position, phoneNumber);
		}
	}

	public Task UpdateStaff(int Id, string phoneNumber)
	{
		if (Id == 16)
		{
			Console.WriteLine("Error");
			return Task.CompletedTask;
		}
		else
		{
			return _staffRepo.UpdateStaff(Id, phoneNumber);
		}
	}

	public Task DeleteStaff(int Id)
	{
		if (Id == 16)
		{
			Console.WriteLine("Error");
			return Task.CompletedTask;
		}
		else
		{
			return _staffRepo.DeleteStaff(Id);
		}
	}


}
