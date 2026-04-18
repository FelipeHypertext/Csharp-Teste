namespace segundoMaior;

class Program
{
    static void Main()
    {
        /*Criação e chamada da função aqui
        Teste rápido:
        var lista = new List<int> { 3, 2, 1, 5, 5, 4 };
        var resultado = SegundoMaior(lista);
        Console.WriteLine(resultado);
        */
    }
    public static int? SegundoMaior(List<int> listaNumeros)
    {
        if (listaNumeros == null || listaNumeros.Distinct().Count() < 2)
        {
            return null;
        }

        int? maior = null;
        int? segundoMaior = null;

        /*
        Verificação caso a lista esteja vazia ou ela tenha 2 ou menos elementos iguais.
            */

        foreach (int num in listaNumeros)
        {
            if (maior == null || num > maior) 
            {
                if (maior != null && num != maior) {
                    segundoMaior = maior;
                }
                maior = num;
            }
            else if (num != maior && (segundoMaior == null || num > segundoMaior))
            {
                    segundoMaior = num; 
            }
        }
        return segundoMaior;
    }
}
