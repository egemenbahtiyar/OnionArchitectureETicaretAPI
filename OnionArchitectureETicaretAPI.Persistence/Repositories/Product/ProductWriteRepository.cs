using OnionArchitectureETicaretAPI.Application.Repositories.Product;
using OnionArchitectureETicaretAPI.Persistence.Contexts;

namespace OnionArchitectureETicaretAPI.Persistence.Repositories.Product;

public class ProductWriteRepository: WriteRepository<Domain.Entities.Product>, IProductWriteRepository
{
    public ProductWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
        
    }

}