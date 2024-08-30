using HomeWork66.BLL.Interfaces;
using HomeWork66.DAL;
using HomeWork66.DAL.Entities;
using HomeWork66.DAL.Interfaces;
using HomeWork66.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork66.Controllers;
[ApiController]
[Route("api/")]
public class StaffController : Controller
{
	private SchoolDBContext _dbContext;
    private IStaffRepo _staffRepo;
    private IStaffService _staffService;

    public StaffController(SchoolDBContext schoolDBContext, IStaffRepo staffRepo, IStaffService staffService)
    {
        _dbContext = schoolDBContext;
        _staffRepo = staffRepo;
        _staffService = staffService;
    }

    [HttpGet("api/Staff/GetStaff")]
    public Task<List<Staff>> GetStaff()
    {
        return _staffService.GetAllStaff();
    }


    [HttpPost("api/Staff/CreatStaff")]
    public Task CreatStaff(StaffCreateModel staffCreate)
    {
        return _staffService.CreateStaff(staffCreate.Name, staffCreate.Surname,
            staffCreate.Position, staffCreate.PhoneNumber);
        
    }

    [HttpPut("api/Staff/UpdatePhoneNumber")]
    public Task UpdatePhoneNumber(StaffUpdateModel staffUpdate)
    {
        return _staffService.UpdateStaff(staffUpdate.Id, staffUpdate.PhoneNumber);
    }

    [HttpDelete("api/Staff/DeleteStaff")]
    public Task DeleteStaff(int Id)
    {
        return _staffService.DeleteStaff(Id);
    }
}
