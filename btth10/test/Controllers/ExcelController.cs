using Microsoft.AspNetCore.Mvc;
using test.Models;
using test.Services;

[ApiController]
[Route("api/excel")]
public class ExcelController : ControllerBase
{
    private readonly ExcelService _excelService;

    public ExcelController(ExcelService excelService)
    {
        _excelService = excelService;
    }

    [HttpGet("customer")]
    public IActionResult GetCustomers()
    {
        var data = _excelService.ReadExcel<Person>("customer.xlsx");
        return Ok(data);
    }

    [HttpGet("product")]
    public IActionResult GetProducts()
    {
        var data = _excelService.ReadExcel<Product>("product.xlsx");
        return Ok(data);
    }
}