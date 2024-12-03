using Microsoft.EntityFrameworkCore;

public class FornecedorRepository : IFornecedorRepository
{
    private readonly AppDbContext _context;

    public FornecedorRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Fornecedor>> GetAllAsync()
    {
        return await _context.Fornecedores.ToListAsync();
    }

    public async Task<Fornecedor> GetByIdAsync(int id)
    {
        return await _context.Fornecedores.FindAsync(id);
    }

    public async Task AddAsync(Fornecedor fornecedor)
    {
        await _context.Fornecedores.AddAsync(fornecedor);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Fornecedor fornecedor)
    {
    var existingFornecedor = await _context.Fornecedores.FindAsync(fornecedor.Id);
    if (existingFornecedor != null)
    {
        
        _context.Entry(existingFornecedor).State = EntityState.Detached;
    }

    _context.Fornecedores.Update(fornecedor);
    await _context.SaveChangesAsync(); 
    }

    public async Task DeleteAsync(int id)
    {
        var fornecedor = await _context.Fornecedores.FindAsync(id);
        if (fornecedor != null)
        {
            _context.Fornecedores.Remove(fornecedor);
            await _context.SaveChangesAsync();
        }
    }
}