using AppCoreBasicaMVC.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppCoreBasicaMVC.Models
{
    public class Fornecedor : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(maximumLength: 100,
             ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(maximumLength: 14,
            ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Documento { get; set; }
        public TipoFornecedor TipoFornedor { get; set; }
        public Endereco Endereo { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
