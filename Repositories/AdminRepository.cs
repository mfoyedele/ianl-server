using WebApi.Entities;

namespace WebApi.Repositories
{
    public interface IAdminRepository
    {
        Task<IEnumerable<Admin>> GetAllAdmins();
        Task<Admin> GetAdminById(int id);
        Task<Admin> GetByEmail(string email);
        Task Create(Admin admin);
        Task Update(Admin admin);
        Task Delete(int id);
    }

    public class AdminRepository : IAdminRepository
    {
        public Task Create(Admin admin)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Admin> GetAdminById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Admin>> GetAllAdmins()
        {
            throw new NotImplementedException();
        }

        public Task<Admin> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task Update(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}