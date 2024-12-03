using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class FornecedoresController : ControllerBase
{
    private readonly IFornecedorRepository _repository;

    public FornecedoresController(IFornecedorRepository repository) => _repository = repository;

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await _repository.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var fornecedor = await _repository.GetByIdAsync(id);
        if (fornecedor == null) return NotFound();
        return Ok(fornecedor);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Fornecedor fornecedor)
    {
        await _repository.AddAsync(fornecedor);
        return CreatedAtAction(nameof(GetById), new { id = fornecedor.Id }, fornecedor);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Fornecedor fornecedor)
    {
        if (id != fornecedor.Id) return BadRequest();
        var existingFornecedor = await _repository.GetByIdAsync(id);
        if (existingFornecedor == null) return NotFound();

        await _repository.UpdateAsync(fornecedor);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var fornecedor = await _repository.GetByIdAsync(id);
        if (fornecedor == null) return NotFound();

        await _repository.DeleteAsync(id);
        return NoContent();
    }
}