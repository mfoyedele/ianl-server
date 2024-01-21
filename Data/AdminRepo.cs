// using Microsoft.EntityFrameworkCore;
// using WebApi.Models.Admin;

// namespace WebApi.Data
// {
//     public class AdminRepo : IAdminRepo
//     {
      
//         private readonly AppDbContext _context;

//         public AdminRepo(AppDbContext context)
//         {
//             _context = context;
//         }

//         public async Task SaveChanges()
//         {
//             await _context.SaveChangesAsync();
//         }

//         public async Task<IEnumerable<AdminModel>> GetAdminAll()
//         {
//             return await _context.Admins!.ToListAsync();
//         }

//         public async Task CreateAdmin(AdminModel adm)
//         {
//             if (adm == null)
//             {
//                 throw new ArgumentNullException(nameof(adm));
//             }

//             await _context.Admins!.AddAsync(adm);
//         }

//         public async Task<AdminModel?> GetAdminById(int id)
//         {
//             return await _context.Admins!.FirstOrDefaultAsync(c => c.Id == id);
//         }

      

//         public void DeleteAdmin(AdminModel amd)
//         {
//             if (amd == null)
//             {
//                 throw new ArgumentNullException(nameof(amd));
//             }
//             _context.Admins.Remove(amd);
//         }
//     }
// }
