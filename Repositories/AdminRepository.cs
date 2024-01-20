namespace WebApi.Repositories;

using Dapper;
using WebApi.Entities;
using WebApi.Helpers;

public interface IAdminRepository
{
    Task<IEnumerable<Admin>> GetAll();
    Task<User> GetById(int id);
    Task<User> GetByEmail(string email);
}

public class AdminRepository : IAdminRepository
{
    public Task<IEnumerable<Admin>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetById(int id)
    {
        throw new NotImplementedException();
    }
}