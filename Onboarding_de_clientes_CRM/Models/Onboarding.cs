namespace Onboarding_de_clientes_CRM.Models
{
    public class Onboarding
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; }
        public DateTime? Prazo { get; set; }
        public string Tipo { get; set; } = "Padrão";
        public PrioridadeUnboarding TipoPrioridade { get; set; } = PrioridadeUnboarding.Baixa;
        public List<Tarefa> Tarefas { get; set; } = new();
        public StatusOnboarding Status { get; set; } = StatusOnboarding.EmAndamento;
    }
}
