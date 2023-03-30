using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]     // in this case controller will be replaced by "Products"
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            _context = context;

        }


        // Endpoint
        [HttpGet]       // https://localhost:5001/api/products
                        // async method, its going to return a task of ActionResult.
                        // In this case we are returning a list of products
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();

            return products;
        }

        // Endpoint
        [HttpGet("{id}")]       // https://localhost:5001/api/products/34
                                // async method, its going to return a task of ActionResult.
                                // In this case we are returning a single product, what has the requested Id
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}