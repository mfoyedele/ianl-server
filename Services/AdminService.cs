using WebApi.Entities;
using WebApi.Models.Admin;
using WebApi.Models.Admins;

namespace WebApi.Services;

public interface IAdminService
{
    Task<IEnumerable<Admin>> GetAll();
    Task<Admin> GetById(int id);
    Task Create(CreateRequest model);
    Task Update(int id, UpdateRequest model);
    Task Delete(int id);
}
