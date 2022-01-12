﻿using LivrariaBoaLeitura.API.Context;
using LivrariaBoaLeitura.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LivrariaBoaLeitura.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrariaController : Controller
    {
        private readonly ToDoContext _context;

        public LivrariaController(ToDoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Livro>>> GetProdutos()
        {
            return await _context.todoLivros.ToListAsync();
        }
    }
}