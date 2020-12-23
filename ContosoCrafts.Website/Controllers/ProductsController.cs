﻿using ContosoCrafts.Website.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCrafts.Website.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            this.ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery]string productId , 
            [FromQuery] int rating)
        {
            ProductService.AddRating(productId, rating);
            return Ok();
        }
    }
}
