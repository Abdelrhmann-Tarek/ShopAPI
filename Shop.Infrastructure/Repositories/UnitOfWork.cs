using Shop.Application.Interfaces;
using Shop.Infrastructure.Data;

namespace Shop.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ShopDbContext _context;

    public IProductRepository Products { get; }

    public UnitOfWork(
        ShopDbContext context,
        IProductRepository productRepository)
    {
        _context = context;
        Products = productRepository;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}