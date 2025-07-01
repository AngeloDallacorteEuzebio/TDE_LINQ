
class Program
{
    static void Main()
    {
        Dictionary<string, double> alunos = new Dictionary<string, double>();

        alunos.Add("Lucas", 10);
        alunos.Add("Ana", 5.0);
        alunos.Add("Pedro", 10);
        alunos.Add("Joana", 5.0);

        var aprovados = alunos.Where(a => a.Value >= 7.0);

        Console.WriteLine("Alunos aprovados:");
        foreach (var aluno in aprovados)
        {
            Console.WriteLine(aluno.Key);
        }
    }
}
