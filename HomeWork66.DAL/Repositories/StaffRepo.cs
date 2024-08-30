using HomeWork66.DAL.Entities;
using HomeWork66.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace HomeWork66.DAL.Repositories;

public class StaffRepo : IStaffRepo
{
	private SchoolDBContext _dbContext;
	
    public StaffRepo(SchoolDBContext schoolDBContext)
    {
        _dbContext = schoolDBContext;
    }

	public async Task<List<Staff>> GetAllStaff()
	{
		var staff = await _dbContext.Staffs.ToListAsync();
		return staff;
	}

    public Task CreateStaff(string name, string surname, string position, string phoneNumber)
	{
		var creatStaff = new Staff()
		{
			Name = name,
			Surname = surname,
			Position = position,
			PhoneNumber = phoneNumber
		};

		_dbContext.Staffs.Add(creatStaff);
		_dbContext.SaveChanges();
		return Task.CompletedTask;
	}


	public Task UpdateStaff(int Id, string phoneNumber)
	{
		var updatedPhoneNumber = _dbContext.Staffs.FirstOrDefault(x => x.Id == Id);
		updatedPhoneNumber.PhoneNumber = phoneNumber;

		_dbContext.Staffs.Update(updatedPhoneNumber);
		_dbContext.SaveChanges();

		return Task.CompletedTask;
	}


	public Task DeleteStaff(int Id)
	{
		var deletedStaff = _dbContext.Staffs.FirstOrDefault(x => x.Id == Id);

		_dbContext.Staffs.Remove(deletedStaff);
		_dbContext.SaveChanges();


		return Task.CompletedTask;
	}

	
}
