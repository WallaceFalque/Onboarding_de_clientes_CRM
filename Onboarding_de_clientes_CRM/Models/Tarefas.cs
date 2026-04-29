namespace Onboarding_de_clientes_CRM.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public int OnboardingId { get; set; }
        public Onboarding Onboarding { get; set; } = null!;
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataPrazo { get; set; }
        public DateTime? DataConclusao { get; set; }
        public int Ordem { get; set; }
        public string? Responsavel { get; set; }
        public StatusTarefa Status { get; set; } = StatusTarefa.NaoIniciada;
    }
}
