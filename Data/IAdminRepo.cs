using WebApi.Models.Admin;

namespace WebApi.Data
{
    public interface IAdminRepo
    {
        Task SaveChanges();

        Task<IEnumerable<AdminModel>> GetAllAdmins();

        Task<AdminModel?> GetAdminById(int id);
        Task CreateAdmin(AdminModel adm);
    
        void DeleteAdmin(AdminModel adm);


    }

}
