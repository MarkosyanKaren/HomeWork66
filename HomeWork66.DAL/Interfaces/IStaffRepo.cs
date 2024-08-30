﻿using HomeWork66.DAL.Entities;

namespace HomeWork66.DAL.Interfaces;

public interface IStaffRepo
{
	public Task<List<Staff>> GetAllStaff();
	public Task CreateStaff(string name, string surname, string position, string phoneNumber);
	public Task UpdateStaff(int Id, string phoneNumber);
	public Task DeleteStaff(int Id);
}
