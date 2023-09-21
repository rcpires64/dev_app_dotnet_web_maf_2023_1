namespace ApplicationLayer
{
    public class Professor
    {
        public int Matricula { get; set; }
        public string Nome { get; set; } = string.Empty; //ou default
        public IEnumerable<string> Conhecimentos { get; set; } = default!;
    }
}
