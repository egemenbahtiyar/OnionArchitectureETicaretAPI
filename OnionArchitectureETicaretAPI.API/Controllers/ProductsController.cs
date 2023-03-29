using System.Net;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureETicaretAPI.Application.Repositories.Product;
using OnionArchitectureETicaretAPI.Application.ViewModels.Products;
using OnionArchitectureETicaretAPI.Domain.Entities;

namespace OnionArchitectureETicaretAPI.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductReadRepository _productReadRepository;
    private readonly IProductWriteRepository _productWriteRepository;

    public ProductsController(
        IProductWriteRepository productWriteRepository,
        IProductReadRepository productReadRepository)
    {
        _productWriteRepository = productWriteRepository;
        _productReadRepository = productReadRepository;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(_productReadRepository.GetAll(false));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(string id)
    {
        return Ok(await _productReadRepository.GetByIdAsync(id, false));
    }

    [HttpPost]
    public async Task<IActionResult> Post(VM_Create_Product model)
    {
        if (ModelState.IsValid)
        {
        }

        await _productWriteRepository.AddAsync(new Product
        {
            Name = model.Name,
            Price = model.Price,
            Stock = model.Stock
        });
        await _productWriteRepository.SaveAsync();
        return StatusCode((int)HttpStatusCode.Created);
    }

    [HttpPut]
    public async Task<IActionResult> Put(VM_Update_Product model)
    {
        var product = await _productReadRepository.GetByIdAsync(model.Id);
        product.Stock = model.Stock;
        product.Name = model.Name;
        product.Price = model.Price;
        await _productWriteRepository.SaveAsync();
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _productWriteRepository.RemoveAsync(id);
        await _productWriteRepository.SaveAsync();
        return Ok();
    }
}