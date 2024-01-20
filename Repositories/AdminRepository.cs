namespace WebApi.Repositories;

using Dapper;
using WebApi.Entities;
using WebApi.Helpers;

public interface IAdminRepository
{
    Task<IEnumerable<Admin>> GetAll();
    Task<Admin> GetById(int id);
    Task<Admin> GetByEmail(string email);
}

public class AdminRepository : IAdminRepository
{
    private DataContext _context;

    public AdminRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Admin>> GetAll()
    {
        using var connection = _context.CreateConnection();
        var sql = """
            SELECT * FROM Admins
        """;
        return await connection.QueryAsync<Admin>(sql);
    }
public async Task<Admin> GetById(int id)
    {
        using var connection = _context.CreateConnection();
        var sql = """
            SELECT * FROM Admins 
            WHERE Id = @id
        """;
        return await connection.QuerySingleOrDefaultAsync<Admin>(sql, new { id });
    }

   public async Task<Admin> GetByEmail(string email)
    {
        using var connection = _context.CreateConnection();
        var sql = """
            SELECT * FROM Admins 
            WHERE Email = @email
        """;
        return await connection.QuerySingleOrDefaultAsync<Admin>(sql, new { email });
    }

 }
