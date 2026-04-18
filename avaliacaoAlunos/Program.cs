using System.Text.RegularExpressions;

namespace avaliacaoAlunos;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string> { "Ana", "Bruno", "Carlos", "Diana" };

        List<int> notas = new List<int> {8, 4, 7, 6, 7};

        Console.WriteLine(situacaoAlunos(nomes, notas));
    }

    public static string? situacaoAlunos(List<string> nomes, List<int> notas)
    {
        int aprovados = 0;
        int recuperacao = 0;
        int reprovados = 0;

        if (nomes.Count == notas.Count)
        {
            for (int i = 0; i < nomes.Count; i++)
            {
                string nome = nomes[i];
                int nota = notas[i];

                if (nota >= 7)
                {
                    Console.WriteLine($"{nome} -> Aprovado");
                    aprovados++;
                } else if (nota >= 5 && nota < 7)
                {
                    Console.WriteLine($"{nome} -> Recuperação");
                    recuperacao++;
                } else
                {
                    Console.WriteLine($"{nome} -> Reprovado");
                    reprovados++;
                }
            }

            return $"\nAprovados: {aprovados}\nRecuperação: {recuperacao}\nReprovados: {reprovados}";
        } else
        {
            return "As listas tem tamanho diferentes.";
        }
    }

}