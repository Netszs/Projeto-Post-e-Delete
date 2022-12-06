using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Post_e_Delete.Models
{
    public class Fornecedor
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Nome")]
        public string Nome { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Por favor, informe o seu Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor, informe o seu Logradouro")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Por favor, informe o seu Numero")]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Por favor, informe o seu Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Por favor, informe a sua Cidade")]
        public string Cidade { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
