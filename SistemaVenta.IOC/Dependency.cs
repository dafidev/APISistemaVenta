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

using SistemaVenta.DAL.Repositories;
using SistemaVenta.DAL.Repositories.Contract;

namespace SistemaVenta.IOC;
public static class Dependency
{
    public static void DependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DbsaleContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("SqlString"));
        });

        //Es genérico, sin lógica propia, liviano, se puede recrear sin problema
        services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        //Usa DbContext, mantiene una transacción y lógica de venta → debe ser coherente durante toda la petición
        services.AddScoped<ISaleRepository, SaleRepository>();
    }
}
