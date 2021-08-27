using System.ComponentModel.DataAnnotations;
using System;
namespace ProdutosAPI.Data.Dtos
{
    public class UpdateProdutoDto
    {
        [Required (ErrorMessage = "Nome obrigatório!")]
        public string Nome {get; set;}

        [Required (ErrorMessage = "Marca obrigatória!")]
        [StringLength(15)]
        public string Marca {get; set;}

        [Required (ErrorMessage = "Preço obrigatório!")]
        public double Preco {get; set;}

        [Required (ErrorMessage = "Distribuidor obrigatório!")]
        [StringLength(15)]
        public string Distribuidor {get; set;}

        [Required (ErrorMessage = "Validade obrigatória!!")]
        public string Validade {get; set;}
    }
}