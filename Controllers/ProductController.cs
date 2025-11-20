using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _repo;

    public ProductController(IProductRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("{serial}")]
    public async Task<IActionResult> GetBySerial(string serial)
    {
        if (string.IsNullOrWhiteSpace(serial))
            return BadRequest("serial is required");

        var result = await _repo.GetProductAggregateAsync(serial);

        return result is not null ? Ok(result) : NotFound();
    }

    // Serve the SerialLookUp.html page
    [HttpGet("/SerialLookup")]
    public IActionResult SerialLookup()
    {
        // Serve wwwroot/SerialLookUp.html
        return PhysicalFile(
            Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "SerialLookUp.html"),
            "text/html"
        );
    }
}
