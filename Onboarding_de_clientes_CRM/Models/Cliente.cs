namespace Onboarding_de_clientes_CRM.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Apelido { get; set; }
        public string? Setor { get; set; }
        public string? Email { get; set; }

        public List<Onboarding> Onboardings { get; set; } = new();
    }
}
