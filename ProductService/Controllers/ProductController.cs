﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ProductLogic;
using ProductLogic.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Product cont = new Product();
        // GET: api/<ProductController>
        [HttpGet]
        public string Get()
        {
            return JsonSerializer.Serialize(cont.Read());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return JsonSerializer.Serialize(cont.Read(id));
        }

        // POST api/<ProductController>
        [HttpPost]
        public string Post([FromBody] ProductEntity product)
        {
            return JsonSerializer.Serialize(cont.Create(product));
        }

        // PUT api/<ProductController>/5
        [HttpPut()]
        public string Put([FromBody] ProductEntity product)
        {
            return  JsonSerializer.Serialize(cont.Update(product));
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
