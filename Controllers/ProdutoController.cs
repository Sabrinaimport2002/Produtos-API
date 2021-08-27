using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProdutosAPI.Models;
using ProdutosAPI.Data.Dtos;
using ProdutosAPI.Data;
using AutoMapper;

namespace ProdutosAPI.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    public class ProdutoController : ControllerBase
    {
       private ProdutoContext _context;
       private IMapper _mapper;
        public ProdutoController(ProdutoContext context, IMapper mapper)
        {
                _context = context;
                _mapper = mapper;
        }
        
        [HttpPost]
        public  IActionResult AdicionaProduto([FromBody] CreateProdutoDto produtoDto )
        {
            Produto produto = _mapper.Map<Produto>(produtoDto);
           _context.Produtos.Add(produto);
           _context.SaveChanges();
            return CreatedAtAction(nameof(RetornaProdutoId), new {Id = produto.Id}, produto);

        }

        [HttpGet]
        public  IEnumerable<Produto> RetornaProduto()
        {
            return _context.Produtos;
        }

       [HttpGet ("{id}")]
        public IActionResult RetornaProdutoId(int id)
        {
             Produto produto = _context.Produtos.FirstOrDefault (produto => produto.Id == id);
            if(produto != null)
            {
                ReadProdutoDto produtoDto = _mapper.Map<ReadProdutoDto>(produto);
                return Ok(produtoDto);
            }
            return NotFound();

        }

        [HttpPut ("{id}")]
        public IActionResult AtualizaProduto(int id, [FromBody] UpdateProdutoDto produtoDto)
        {
            Produto produto = _context.Produtos.FirstOrDefault (produto => produto.Id == id);
            if(produto == null)
                return NotFound();
            _mapper.Map(produtoDto, produto);
            _context.SaveChanges();
            return NoContent();

        }

        [HttpDelete ("{id}")]
        public IActionResult RemoveProduto(int id)
        {
            Produto produto = _context.Produtos.FirstOrDefault (produto => produto.Id == id);
            if(produto == null)
                  return NotFound();
            _context.Remove(produto);
            _context.SaveChanges();
            return NoContent();

        }


    }
}