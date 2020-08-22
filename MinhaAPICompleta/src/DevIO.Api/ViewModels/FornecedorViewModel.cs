using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevIO.Api.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(14, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres")]
        public string Documento { get; set; }

        public int TipoFornecedor { get; set; }
        public EnderecoViewModel Endereco { get; set; }

        public bool Ativo { get; set; }

        /*EF Relations*/
        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
