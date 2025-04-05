using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using SistemaVenta.DAL.DBContext;
using SistemaVenta.DAL.Repositories.Contract;
using SistemaVenta.MODEL;

namespace SistemaVenta.DAL.Repositories;
public class SaleRepository: GenericRepository<Sale>, ISaleRepository
{
    private readonly DbsaleContext _dbContext;

    public SaleRepository(DbsaleContext dbContext):base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Sale> Register(Sale entity)
    {
        Sale saleGenerated = new Sale();

        using (var transaction = _dbContext.Database.BeginTransaction())
        {
            try
            {
                foreach (SaleDetail sd in entity.SaleDetails)
                {
                    Product product_found = _dbContext.Products.Where(p => p.ProductId == sd.ProductId).FirstOrDefault();

                    product_found.Stock = product_found.Stock - sd.Quantity;
                    _dbContext.Products.Update(product_found);
                }
                await _dbContext.SaveChangesAsync();

                DocumentNumber correlative = _dbContext.DocumentNumbers.First();

                correlative.LastNumber = correlative.LastNumber + 1;
                correlative.DateRecord = DateTime.Now;

                _dbContext.DocumentNumbers.Update(correlative);
                await _dbContext.SaveChangesAsync();

                //int numberOfDigits = 4;
                //string zeros = string.Concat(Enumerable.Repeat("0", numberOfDigits));
                //string saleNumber = zeros + correlative.LastNumber.ToString();
                //saleNumber = saleNumber.Substring(saleNumber.Length - numberOfDigits, numberOfDigits);
                string saleNumber = correlative.LastNumber.ToString("D4");

                entity.DocumentNumber = saleNumber;

                await _dbContext.Sales.AddAsync(entity);
                await _dbContext.SaveChangesAsync();

                saleGenerated = entity; 

                transaction.Commit();

            }
            catch 
            {
                transaction.Rollback();
                throw;
            }

            return saleGenerated;
        }
    }
}
