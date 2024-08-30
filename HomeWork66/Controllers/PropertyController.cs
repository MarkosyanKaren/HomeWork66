using HomeWork66.BLL.Interfaces;
using HomeWork66.DAL;
using HomeWork66.DAL.Entities;
using HomeWork66.DAL.Interfaces;
using HomeWork66.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork66.Controllers;

[ApiController]
[Route("api/")]
public class PropertyController : Controller
{
	private SchoolDBContext _dbContext;
	private IPropertyRepo _propertyRepo;
	private IPropertyService _propertyService;
    public PropertyController(SchoolDBContext schoolDBContext, IPropertyRepo propertyRepo, IPropertyService propertyService)
    {
        _dbContext = schoolDBContext;
        _propertyRepo = propertyRepo;
        _propertyService = propertyService;
    }

    [HttpGet("api/Property/GetProperty")]
    public Task<List<Property>> GetProperties()
    {
        return _propertyService.GetAllProperty();
    }

    [HttpPost("api/Property/CreateProperty")]
    public Task CreateProperty(PropertyCreateModel model)
    {
        return _propertyService.CreateProperty(model.Name, model.Count);
    }

    [HttpPut("api/Property/UpdateCount")]
    public Task UpdateCount(PropertyUpdateModel model)
    {
        return _propertyService.UpdateProperty(model.Id, model.Count);
    }

    [HttpDelete("api/Property/DeleteProperty")]
    public Task DeleteProperty(int id)
    {
        return _propertyService.DeleteProperty(id);
    }

}
