using Microsoft.EntityFrameworkCore;

namespace EVS.Api.Datas
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {

    }
}
