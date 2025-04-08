using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniLojaVirtual.Commom.Model
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "O campo {0} precisa tem entre {1} e {2} caracteres")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "O campo {0} precisa tem entre {1} e {2} caracteres")]
        public string? Descricao { get; set; }
        public string? Imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int? Estoque { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string? VendedorId { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
        public Vendedor? Vendedor { get; set; }

    }
}
