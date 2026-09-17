namespace GestorOrdemDeServico.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public ICollection<OrdemServico> Ordens { get; set; } = new List<OrdemServico>();
    }
}
