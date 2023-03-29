using Microsoft.AspNetCore.Mvc;
using OnionArchitectureETicaretAPI.Application.Repositories.Customer;
using OnionArchitectureETicaretAPI.Application.Repositories.Order;
using OnionArchitectureETicaretAPI.Application.Repositories.Product;
using OnionArchitectureETicaretAPI.Domain.Entities;

namespace OnionArchitectureETicaretAPI.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    readonly private IProductWriteRepository _productWriteRepository;
    readonly private IProductReadRepository _productReadRepository;

    readonly private IOrderWriteRepository _orderWriteRepository;
    readonly private IOrderReadRepository _orderReadRepository;

    readonly private ICustomerWriteRepository _customerWriteRepository;
    public ProductsController(
        IProductWriteRepository productWriteRepository,
        IProductReadRepository productReadRepository,
        IOrderWriteRepository orderWriteRepository,
        ICustomerWriteRepository customerWriteRepository,
        IOrderReadRepository orderReadRepository)
    {
        _productWriteRepository = productWriteRepository;
        _productReadRepository = productReadRepository;
        _orderWriteRepository = orderWriteRepository;
        _customerWriteRepository = customerWriteRepository;
        _orderReadRepository = orderReadRepository;
    }

    [HttpGet]
    public async Task Get()
    {
        Product product = new Product()
        {
            Name = "Kalem",
            Price = 10.512f,
            Stock = 100
        };
        await _productWriteRepository.AddAsync(product);
        await _productWriteRepository.SaveAsync();

    }

}