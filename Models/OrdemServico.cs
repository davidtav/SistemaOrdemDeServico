using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace GestorOrdemDeServico.Models
{
    public class OrdemServico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da categoria é obrigatório.")]
        [StringLength(300)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [StringLength(300)]
        [Display(Name = "Observações")]
        public string? Observacoes { get; set; }

        [Required()]
        [Display(Name = "Data de Abertura")]
        [DataType(DataType.Date)]
        public DateTime DataAbertura { get; set; } = DateTime.Now;



        [Display(Name = "Data de Conclusão")]
        [DataType(DataType.Date)]
        public DateTime? DataConclusao { get; set; }
        public StatusOrdem Status { get; set; }

        [Required(ErrorMessage ="informe o valor do serviço")]
        [Display(Name = "Valor")]
        [Range(0, 999999.99, ErrorMessage = "O valor deve estar entre 0 e 999999.99")]
        [Column(TypeName = "decimal(10, 2)")]
        public Decimal Valor { get; set; }

        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        public CategoriaServico? CategoriaServico { get; set; }
        public int?  CategoriaServicoId { get; set; }
    }
}
