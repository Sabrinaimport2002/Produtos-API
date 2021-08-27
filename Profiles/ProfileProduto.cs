using ProdutosAPI.Data;
using ProdutosAPI.Data.Dtos;
using AutoMapper;
using ProdutosAPI.Models;
namespace ProdutosAPI.Profiles
{
    public class ProfileProduto : Profile
    {
        public ProfileProduto()
        {
            CreateMap<CreateProdutoDto, Produto>();
            CreateMap<Produto, ReadProdutoDto>();
            CreateMap<UpdateProdutoDto, Produto>();
        }
    }
    
}