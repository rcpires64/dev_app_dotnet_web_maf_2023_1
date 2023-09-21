namespace ApplicationLayer
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; } = string.Empty; //ou default
        public DateOnly DataNascimento { get; set; } = default;
    }
}