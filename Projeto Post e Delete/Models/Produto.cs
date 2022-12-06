using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Post_e_Delete.Models
{
    public class Produto
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome do produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe a descricao do produto")]
        public string Descricao { get; set; }


        public Fornecedor Fornecedor { get; set; }
    }
}
