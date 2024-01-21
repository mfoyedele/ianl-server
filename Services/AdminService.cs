using WebApi.Entities;
using WebApi.Models.Admin;
using WebApi.Models.Admins;

namespace WebApi.Services;

public interface IAdminService
{
    Task<IEnumerable<Admin>> GetAdminAll();
    Task<Admin> GetAdminById(int id);
    Task Create(CreateRequest model);
    Task Update(int id, UpdateRequest model);
    Task Delete(int id);
}

public class AdminService : IAdminService
{
    public Task Create(CreateRequest model)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Admin>> GetAdminAll()
    {
        throw new NotImplementedException();
    }

    public Task<Admin> GetAdminById(int id)
    {
        throw new NotImplementedException();
    }

    public Task Update(int id, UpdateRequest model)
    {
        throw new NotImplementedException();
    }
}