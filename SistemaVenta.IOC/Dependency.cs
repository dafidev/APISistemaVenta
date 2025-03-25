using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVenta.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.IOC;
public static class Dependency
{
    public static void DependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DbsaleContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("SqlString"));
        });
    }
}
