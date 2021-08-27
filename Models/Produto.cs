using System;
using System.ComponentModel.DataAnnotations;
namespace ProdutosAPI.Models
{
    public class Produto
    {
        [Key]
        [Required]
        public int Id {get; set;}

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